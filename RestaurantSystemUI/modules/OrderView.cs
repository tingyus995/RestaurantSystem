using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RestaurantSystemCore.models;
using System.Collections.ObjectModel;
using FontAwesome.Sharp;
using RestaurantSystemCore;

namespace RestaurantSystemUI.modules
{
    public partial class OrderView : UserControl
    {
        //private List<Food> foods = new List<Food>();


        /*private NextButtonAppearance nextButtonAppearance;

        public NextButtonAppearance NextButtonAppearance { 
            get {
                return nextButtonAppearance;
            } 
            set {
                nextButtonAppearance = value;

                btnNext.Text = value.Text;
                btnNext.BackColor = value.background;
                btnNext.IconChar = value.Icon;

            }
        }*/

        private Order order;
        public bool Editable { get; set; } = false;


        public int Total { get; set; } = 0;

        public event EventHandler NextButtonClicked;

        public void Reset()
        {
            fpnFoodItems.Controls.Clear();
            lbOrderNumber.Text = String.Format("#{0}", OrderManager.No);
            updateTotal();
        }

        private void AddOrUpdateFoodItem(Food f, int amount)
        {
            foreach (OrderViewFoodItem item in fpnFoodItems.Controls)
            {
                if (item.Food.Id == f.Id && item.Food.SelectedVarientIndex == f.SelectedVarientIndex)
                {
                    item.Amount += amount;
                    return;
                }
            }

            Food clonedFood = f.clone();
            clonedFood.Amount = 1;

            OrderViewFoodItem it = new OrderViewFoodItem()
            {
                Food = clonedFood,
                ShowRemoveIcon = Editable
            };

            it.FoodAmountChanged += (object _s, EventArgs _e) =>
            {
                updateTotal();
            };

            fpnFoodItems.Controls.Add(it);
        }

        public void AddFood(Food f, int amount = 1)
        {
            AddOrUpdateFoodItem(f, amount);
            updateTotal();
        }

        public Food[] GetFoods()
        {
            List<Food> result = new List<Food>();
            
            foreach(OrderViewFoodItem item in fpnFoodItems.Controls)
            {
                result.Add(item.Food);
            }

            return result.ToArray();
        
        }

        void updateTotal()
        {
            int result = 0;
            if(fpnFoodItems.Controls != null)
                foreach(OrderViewFoodItem item in fpnFoodItems.Controls)
                {
                    result += (item.Food.BasePrice + item.Food.Varients[item.Food.SelectedVarientIndex].delta) * item.Amount;                
                }

            Total = result;
            lbTotal.Text = string.Format("共 {0} 元", Total.ToString());
        }
        
        
        public OrderView()
        {
            InitializeComponent();
        }

        public OrderView(Order o)
        {
            InitializeComponent();
            order = o;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            NextButtonClicked?.Invoke(this, new EventArgs());   
        }

        public void SetNextButton(string text, IconChar icon, Color background)
        {
            btnNext.Text = text;
            btnNext.IconChar = icon;
            btnNext.BackColor = background;
        }

        private void UpdateStatusUI()
        {
            Color queuing = Color.FromArgb(230, 126, 34);
            Color preparing = Color.FromArgb(241, 196, 15);
            Color ready = Color.FromArgb(39, 174, 96);
            Color finished = Color.FromArgb(149, 165, 166);

            switch (order.Status)
            {
                case Order.OrderStatus.Queuing:
                    lbStatus.Text = "排隊中";
                    lbStatus.BackColor = queuing;
                    SetNextButton("設為製作中", IconChar.MortarPestle, preparing);
                    break;
                case Order.OrderStatus.Making:
                    lbStatus.Text = "製作中";
                    lbStatus.BackColor = preparing;
                    SetNextButton("設為可取餐", IconChar.UserCheck, ready);
                    break;
                case Order.OrderStatus.Ready:
                    lbStatus.Text = "可取餐";
                    lbStatus.BackColor = ready;
                    SetNextButton("訂單完成", IconChar.UserCheck, finished);
                    break;
                case Order.OrderStatus.Finished:
                    lbStatus.Text = "訂單完成";
                    lbStatus.BackColor = finished;
                    //SetNextButton("訂單完成", IconChar.UserCheck, finished);
                    btnNext.Visible = false;
                    break;

                case Order.OrderStatus.Cancelled:
                    break;
            }

        }

        private void OrderView_Load(object sender, EventArgs e)
        {

            lbOrderNumber.Text = String.Format("#{0}", OrderManager.No);

            if (order != null) {
                //MessageBox.Show(order.Foods.Length.ToString());
                foreach (Food f in order.Foods)
                {
                    OrderViewFoodItem it = new OrderViewFoodItem()
                    {
                        Food = f,
                        ShowRemoveIcon = Editable
                    };

                    fpnFoodItems.Controls.Add(it);


                }
                lbOrderNumber.Text = String.Format("#{0}", order.No.ToString());
                //lbWaitTime.Visible = true;
                updateWaitTime();
                pnCreatedOrderInfo.Visible = true;
                tmUpdateWaitTime.Enabled = true;

                // next button
                UpdateStatusUI();

                btnNext.Click += (object _s, EventArgs _e) =>
                {
                    switch (order.Status)
                    {
                        case Order.OrderStatus.Queuing:
                            order.Status = Order.OrderStatus.Making;
                            break;
                        case Order.OrderStatus.Making:
                            order.Status = Order.OrderStatus.Ready;
                            break;
                        case Order.OrderStatus.Ready:
                            order.Status = Order.OrderStatus.Finished;
                            order.FinishedAt = DateTime.Now;
                            break;
                        
                    }
                    // save to db

                    OrderManager.UpdateOrder(order);

                    UpdateStatusUI();
                };

                updateTotal();
            }
        }

        private void updateWaitTime()
        {
            TimeSpan timeElapsed;


            if (order.Status == Order.OrderStatus.Finished)
            {
                timeElapsed = order.FinishedAt - order.CreatedAt;
            }
            else
            {
                timeElapsed = DateTime.Now - order.CreatedAt;
            }



            if (timeElapsed.TotalSeconds < 60)
            {
                lbWaitTime.Text = timeElapsed.Seconds + "秒";

            }
            else if (timeElapsed.TotalSeconds < 60 * 60)
            {
                lbWaitTime.Text = string.Format("{0}分{1}秒", timeElapsed.Minutes, timeElapsed.Seconds);
            }
            else
            {
                lbWaitTime.Text = string.Format("{0}時{1}分{2}秒", timeElapsed.Hours, timeElapsed.Minutes, timeElapsed.Seconds);
            }



            if (order.Status == Order.OrderStatus.Finished) lbWaitTime.Enabled = false;
            //lbWaitTime.Text = "已等候時間：" + (DateTime.Now - order.CreatedAt).ToString(@"hh\:mm\:ss");
        }

        private void tmUpdateWaitTime_Tick(object sender, EventArgs e)
        {            
            updateWaitTime();
        }
    }


    /*public class NextButtonAppearance
    {
        public string Text { get; set; }
        public IconChar Icon { get; set; }
        public Color background { get; set; }
    }*/
}