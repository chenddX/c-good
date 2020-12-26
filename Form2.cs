using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            HtmlDocument htmlDoc = webBrowser1.Document;
            HtmlElement btnElement = htmlDoc.All["btnClose"];
            if (btnElement != null)
            {
                btnElement.Click += new HtmlElementEventHandler(HtmlBtnClose_Click);
            }
            HtmlDocument doc = webBrowser1.Document;
            HtmlElement elementcol = doc.GetElementById("1");
            elementcol.SetAttribute("value", "王小明");
            elementcol = doc.GetElementById("2");
            elementcol.SetAttribute("value", "21181323");
            elementcol = doc.GetElementById("3");
            elementcol.SetAttribute("value", "41108120000526207X");
            elementcol = doc.GetElementById("4");
            elementcol.SetAttribute("value", "吉林省长春市");
            elementcol = doc.GetElementById("5");
            elementcol.SetAttribute("value", "15939910863");
            elementcol = doc.GetElementById("6");
            elementcol.SetAttribute("value", "36");
            elementcol = doc.GetElementById("7");
            elementcol.SetAttribute("value", "小王");
            elementcol = doc.GetElementById("8");
            elementcol.SetAttribute("value", "计算机科学与技术学院");
            elementcol = doc.GetElementById("9");
            elementcol.SetAttribute("value", "长春市朝阳区");
            elementcol = doc.GetElementById("10");
            elementcol.SetAttribute("value", "吉林省长春市");
            elementcol = doc.GetElementById("11");
            elementcol.SetAttribute("value", "吉林大学前卫南区北苑一公寓");
            elementcol = doc.GetElementById("12");
            elementcol.SetAttribute("value", "计算机楼a503");
            elementcol = doc.GetElementById("13");
            elementcol.SetAttribute("value", "计算机楼a503");
            HtmlElement a1 = htmlDoc.All["100"];
            a1.SetAttribute("value", "1");
            a1 = htmlDoc.All["101"];  
            a1.SetAttribute("value", "1");
            a1 = htmlDoc.All["102"];
            a1.SetAttribute("value", "1");
            a1 = htmlDoc.All["103"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["105"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["112"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["115"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["116"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["118"];
            a1.SetAttribute("value", "1");
            a1 = htmlDoc.All["119"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["121"];
            a1.SetAttribute("value", "1");
            a1 = htmlDoc.All["122"];
            a1.SetAttribute("value", "1");
            a1 = htmlDoc.All["124"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["126"];
            a1.SetAttribute("checked", "checked");
            a1 = htmlDoc.All["127"];
            a1.SetAttribute("checked", "checked");
            elementcol.InvokeMember("click");
            HtmlDocument htmlDoc1 = webBrowser1.Document;
            HtmlElement btnElement1 = htmlDoc1.All["btnSubmit"];
            if (btnElement1 != null)
            {
                btnElement1.Click += new HtmlElementEventHandler(HtmlBtnSubmit_Click);
            }
            HtmlElementCollection elc = this.webBrowser1.Document.GetElementsByTagName("input");
            foreach (HtmlElement el in elc)
            {
                if (el.GetAttribute("type").Equals("submit"))
                {
                    el.InvokeMember("Click");
                }
            }

        }

        private void WebBrowser_Navigated(object sender, WebBrowserNavigatedEventArgs e)
        {
            //throw new NotImplementedException();
            webBrowser1.DocumentText= webBrowser1.Url.ToString();
        }

        private void HtmlBtnSubmit_Click(object sender, HtmlElementEventArgs e)
        {
            //throw new NotImplementedException();
            //Console.WriteLine("XXXX");
            // Form5 form5 = new Form5();
           DateTime dt=Convert.ToDateTime(Form5.str);
            DateTime now = DateTime.Now;


            if (now < dt)
                {

                    Form3 form3= new Form3();
                    form3.Show();
                //Console.WriteLine(Form5.str);

                }
                else
                {
                    Form4 form4 = new Form4();
                  form4.Show();
                }
                //this.Hide();
            }

        private void HtmlBtnClose_Click(object sender, HtmlElementEventArgs e)
        {
            //throw new NotImplementedException();
            Application.Exit();
        }
    }
}
