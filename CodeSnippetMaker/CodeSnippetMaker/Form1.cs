using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeSnippetMaker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private bool NullCheck(params string[] strs)
        {
            foreach(var s in strs)
            {
                if(s is null)
                {
                    return false;
                }
                else if (s == "")
                {
                    return false;
                }
            }
            return true;
        }
        private void OutputButtonClick(object sender, EventArgs e)
        {
            var title = this.titleBox.Text;
            var author = this.authorBox.Text;
            var description = this.descriptionBox.Text;
            var shortcut = this.shortcutBox.Text;
            var language = this.typeBox.Text;
            var codeBuilder = new StringBuilder();
            foreach(var s in this.codeBox.Lines)
            {
                codeBuilder.AppendLine(s);
            }
            var code = codeBuilder.ToString();
            if (!NullCheck(title, author, description, shortcut, language, code))
            {
                MessageBox.Show("入力されてない要素があります");
                return;
            }
            var builder = new StringBuilder();
            builder.Append(Properties.Resources.BaseText);
            builder.Replace("{title}", title);
            builder.Replace("{author}", author);
            builder.Replace("{description}", description);
            builder.Replace("{shortcut}", shortcut);
            builder.Replace("{language}", language);
            builder.Replace("{code}", code);
            var sfd = new SaveFileDialog
            {
                Filter = "snippet file(*.snippet)|*.snippet|all file(*.*)|*.*"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using(var fs = new System.IO.StreamWriter(sfd.FileName))
                {
                    fs.Write(builder.ToString());
                }
            }
        }
    }
}
