using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;
#pragma warning disable CS0105 
#pragma warning restore CS0105 
using System.Text.RegularExpressions;



namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {

        string ratigf;
        string modelf;
        string brandf;
        string linkintable;
        string linkf;
        int counter = 0;
        string test;

        List<Uri> uriList = new List<Uri>();
        DataTable table = new DataTable("PhotoFormumDataTable");

        public Form1()
        {

            InitializeComponent();


            uriList.Add(new Uri("https://photo-forum.net/i/2426108", UriKind.RelativeOrAbsolute));
      
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            InitTable();
            table.Columns.Add("Manufacturer ", typeof(string));
            table.Columns.Add("Model ", typeof(string));
            table.Columns.Add("Rating ", typeof(string));
            table.Columns.Add("Link ", typeof(string));
            photoForumData.DataSource = table;
            photoForumData.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            photoForumData.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            photoForumData.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            photoForumData.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
        }

        public async void InitTable()
        {

            HtmlWeb web = new HtmlWeb();

            if (counter == uriList.Count)
            {
                MessageBox.Show("Out of range!\nInsert more links!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                counter = counter - 1;
                table.Rows.RemoveAt(table.Rows.Count - 1);
            }
            
            else if (counter == -1)
            {
                MessageBox.Show("Out of range!", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                counter = 0;
                table.Rows.RemoveAt(table.Rows.Count - 1);
            }

            var pagePF = await Task.Factory.StartNew(() => web.Load(uriList[counter].AbsoluteUri));

            var manufacturerNode = pagePF.DocumentNode.SelectNodes("/html//div//div//div//div//div//div//div//div//div//div//span");
            var modelNode = pagePF.DocumentNode.SelectNodes("/html//div//div//div//div//div//div//div//div//div//div//span");
            var ratingNode = pagePF.DocumentNode.SelectNodes("/html//div//div//div//div//div//div//div//ul//li//ul//li");
            var pictureNode = pagePF.DocumentNode.SelectNodes("//img/@src");

            var pictureLink = pictureNode.Select(node => node.OuterHtml);
            var manufacturer = manufacturerNode.Select(node => node.InnerText);
            var model = modelNode.Select(node => node.InnerText);
            var rating = ratingNode.Select(node => node.InnerText);

            linkf = pictureLink.ElementAt(0);

            string pattern = @"https\S+.jpg";
            Match m = Regex.Match(linkf, pattern);
            test = m.ToString();
            modelf = model.ElementAt(12).ToString();
            brandf = model.ElementAt(10).ToString();
            ratigf = rating.ElementAt(0).ToString();
            linkintable = uriList[counter].ToString();


            if (modelf.EndsWith("y."))
            {
                modelf = "Incorect";
                brandf = "Incorect";
                ratigf = "Incorect";
                table.Rows.Add(brandf, modelf, ratigf, linkintable);
                
            }
            else
            {
                table.Rows.Add(brandf, modelf, ratigf, linkintable);

                Uri convertedUri = new Uri(test);
                pictureBox1.ImageLocation = convertedUri.AbsoluteUri;
            }
        }


        private void nextLink_Click(object sender, EventArgs e)
        {
            counter++;
            InitTable();
        }

        private void previousLink_Click(object sender, EventArgs e)
        {
            counter--;
            InitTable();
        }

        public async void button2_Click(object sender, EventArgs e)
        {

            Uri convertedUri = new Uri(URLInput.Text);


            HtmlWeb web = new HtmlWeb();

            var pagePF = await Task.Factory.StartNew(() => web.Load(convertedUri.AbsoluteUri));
            var manufacturerNode = pagePF.DocumentNode.SelectNodes("/html//div//div//div//div//div//div//div//div//div//div//span");
            var modelNode = pagePF.DocumentNode.SelectNodes("/html//div//div//div//div//div//div//div//div//div//div//span");
            var ratingNode = pagePF.DocumentNode.SelectNodes("/html//div//div//div//div//div//div//div//ul//li//ul//li");
            var pictureNode = pagePF.DocumentNode.SelectNodes("//img/@src");

            var pictureLink = pictureNode.Select(node => node.OuterHtml);
            var manufacturer = manufacturerNode.Select(node => node.InnerText);
            var model = modelNode.Select(node => node.InnerText);
            var rating = ratingNode.Select(node => node.InnerText);

            linkf = pictureLink.ElementAt(0);

            string pattern = @"https\S+.jpg";
            Match m = Regex.Match(linkf, pattern);
            test = m.ToString();
            modelf = model.ElementAt(12).ToString();
            brandf = model.ElementAt(10).ToString();
            ratigf = rating.ElementAt(0).ToString();
            linkintable = uriList[counter].ToString();


            if (modelf.EndsWith("y."))
            {
                modelf = "Incorect";
                brandf = "Incorect";
                ratigf = "Incorect";
                table.Rows.Add(brandf, modelf, ratigf, linkintable);
                MessageBox.Show("Invalid Picture.", "ERROR",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                table.Rows.Add(brandf, modelf, ratigf, linkintable);

                Uri convertedUri2 = new Uri(test);
                pictureBox1.ImageLocation = convertedUri2.AbsoluteUri;
            }
        }
    }

}
