using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using RestaurantSystemCore.models;
using RestaurantSystemCore;

namespace RestaurantSystemUI
{
    public partial class BatchFoodImportTool : Form, IThemeable
    {
        public BatchFoodImportTool()
        {
            InitializeComponent();
        }

        BackgroundWorker bgWorker = new BackgroundWorker();

        List<string> filesToImport;

        private void btnBrowse_Click(object sender, EventArgs e)
        {



            if (DialogResult.OK == folderBrowserDialog1.ShowDialog())
            {

                Food[] foods = FoodManager.GetFoods();

                string[] supportedExts = Utility.GetSupportedImageFilenameExtensions();
                string[] files = Directory.GetFiles(folderBrowserDialog1.SelectedPath);

                textBox1.AppendText("開啟的資料夾：" + folderBrowserDialog1.SelectedPath + Environment.NewLine);

                filesToImport = new List<string>();

                bool shouldImport = true;

                foreach (string file in files)
                {
                    Console.WriteLine(file);
                    foreach(string ext in supportedExts)
                    {
                        Console.WriteLine("." + ext);
                        if(file.EndsWith("." + ext))
                        {
                            shouldImport = true;
                            
                            foreach(Food fd in foods)
                            {
                                if(fd.Name == Path.GetFileNameWithoutExtension(file))
                                {
                                    textBox1.AppendText(Environment.NewLine + String.Format("資料庫中已有名為「{0}」的食物，該檔案已被忽略，請修改檔案名稱後再進行匯入。", Path.GetFileNameWithoutExtension(file)));
                                    shouldImport = false;
                                    break;
                                }
                            }

                            if (shouldImport)
                            {
                                filesToImport.Add(file);
                                textBox1.AppendText(Environment.NewLine + Path.GetFileName(file));

                            }

                            break;
                        }
                    }
                }

                textBox1.AppendText(Environment.NewLine + String.Format("共偵測到 {0} 個可匯入的圖片", filesToImport.Count));



                
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if(filesToImport == null)
            {
                MessageBox.Show("請先瀏覽並選定資料夾 才可匯入圖片喔!");
                return;
            }


            if(filesToImport.Count < 1)
            {
                MessageBox.Show("您選擇資料夾中 無任何符合的食物圖片可匯入");
                return;
            }

            if (flatTextbox1.textBox.Text == "")
            {
                MessageBox.Show("請設置初始價錢");
                return;
            }

            bgWorker.RunWorkerAsync();
            




            //string[] files = Directory.GetFiles(fbd.SelectedPath);

            //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
        }

        private void BatchFoodImportTool_Load(object sender, EventArgs e)
        {
            bgWorker.WorkerReportsProgress = true;
            bgWorker.WorkerSupportsCancellation = false;
            bgWorker.ProgressChanged += BgWorker_ProgressChanged;
            bgWorker.RunWorkerCompleted += BgWorker_RunWorkerCompleted;
            bgWorker.DoWork += BgWorker_DoWork;

            ApplyTheme();
        }

        private void BgWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            int counter = 0;

            foreach (string path in filesToImport)
            {
                ++counter;
                Console.WriteLine(path);
                Bitmap img = new Bitmap(path);

                Food food = new Food()
                {
                    SelectedVarientIndex = -1,
                    Name = Path.GetFileNameWithoutExtension(path),
                    BasePrice = int.Parse(flatTextbox1.textBox.Text),
                    Image = Utility.ImageToBytes(img),
                    Varients = new Varient[] { new Varient { Name = "中", delta = 0 } },
                    Categories = new string[] { "自動匯入的食物" }
                };


                FoodManager.UpdateOrSaveFood(food);

                worker.ReportProgress(Convert.ToInt32(((float)counter / filesToImport.Count) * 100f), Environment.NewLine + "正在匯入食物：" + Path.GetFileNameWithoutExtension(path));
            }
        }

        private void BgWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 0;
            MessageBox.Show("所有食物已匯入完成！", "資訊", MessageBoxButtons.OK, MessageBoxIcon.Information);
            filesToImport.Clear();
            filesToImport = null;
            textBox1.AppendText(Environment.NewLine + "所有食物已匯入完成。若要匯入新的食物，請重新選擇資料夾");

        }

        private void BgWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine(e.ProgressPercentage);
            progressBar1.Value = e.ProgressPercentage;
            textBox1.AppendText(e.UserState as string);
        }

        public void ApplyTheme()
        {
            ColorTheme theme = ThemeProvider.GetTheme();
            BackColor = theme.ContentPanel;
            flatTextbox1.BackColor = theme.ContentPanel;
        }
    }
}
