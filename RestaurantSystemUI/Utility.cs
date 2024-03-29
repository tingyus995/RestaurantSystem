﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantSystemUI
{
    public static class Utility
    {
        public static string ImageToBase64(Image image)
        {
            if (image == null) return null;
                // Convert byte[] to Base64 String
                string base64String = Convert.ToBase64String(ImageToBytes(image));
                return base64String;            
        }

        public static byte[] ImageToBytes(Image image)
        {
            if (image == null) return null;
            using (MemoryStream ms = new MemoryStream())
            {
                // Convert Image to byte[]
                image.Save(ms, ImageFormat.Png);
                return ms.ToArray();
            }
        }

        /// base64 To Image
        public static Bitmap Base64ToImage(string base64String)
        {
            if (base64String == null) return null;
            // Convert Base64 String to byte[]
            byte[] imageBytes = Convert.FromBase64String(base64String);
            return BytesToImage(imageBytes);
        }
        /// bytes To Image
        public static Bitmap BytesToImage(byte[] imageBytes)
        {
            if (imageBytes == null) return null;
            using (var ms = new MemoryStream(imageBytes, 0, imageBytes.Length))
            {

                // Convert byte[] to Image
                ms.Write(imageBytes, 0, imageBytes.Length);
                Bitmap image = new Bitmap(ms, true);
                return image;
            }
        }

        /// Show full space dialog in module
        
        public static void ShowFullSpaceDialog(UserControl parent, UserControl child)
        {
            parent.Controls.Add(child);
            child.Top = 0;
            child.Left = 0;

            child.Width = parent.Width;
            child.Height = parent.Height;

            child.BringToFront();

            parent.Resize += (object sender, EventArgs e) =>
            {
                child.Width = parent.Width;
                child.Height = parent.Height;
            };
        }

        public static string GetSupportedImageFilter()
        {
            // reference https://stackoverflow.com/questions/2069048/setting-the-filter-to-an-openfiledialog-to-allow-the-typical-image-formats
            
            string result = "Supported Image Files |";
            
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();
            bool first = true;

            foreach (var c in codecs)
            {
                if (first) first = false;
                else result += "; ";
                result += c.FilenameExtension.ToLower();
            }

            return result;
        }


        public static string[] GetSupportedImageFilenameExtensions()
        {
            List<string> result = new List<string>();

            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageEncoders();            

            foreach (var c in codecs)
            {
                
                result.AddRange(c.FilenameExtension.Replace("*.","").ToLower().Split(';'));
            }            
            return result.ToArray();
        }

        public static Bitmap GetImageFromUser()
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = GetSupportedImageFilter();
            ofd.CheckFileExists = true;

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                return new Bitmap(ofd.FileName);
            }

            return null;
        }

        public static string Sha1Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }

        public static MainWindow GetMainWindow()
        {
            return Program.mainWindow;
        }
    }
}
