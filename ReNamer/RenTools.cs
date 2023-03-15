using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace ReNamer
{
    public class RenTools
    {
        private bool remspaces;
        private bool remnumbers;
        private bool tolowercase;
        private bool touppercase;

        public RenTools()
        {
            this.remspaces = false;
            this.remnumbers = false;
            this.tolowercase = false;
            this.touppercase = false;
        }
        public void setOptions(bool remspaces, bool remnumbers, bool tolowercase, bool touppercase)
        {
            this.remspaces = remspaces;
            this.remnumbers = remnumbers;
            this.tolowercase = tolowercase;
            this.touppercase = touppercase;
        }
        public ListBox doWork(ListBox lb, string search, string replace, bool isregex, string path,ProgressBar p)
        {
            if (this.remspaces)
                lb = removeSpaces(lb,path);
            p.Value = 20;
            if(this.remnumbers)
                lb = removeNumbers(lb,path);
            p.Value = 40;
            if (this.touppercase)
                lb = toUppercase(lb, path);
            p.Value = 60;
            if (this.tolowercase)
                lb = toLowercase(lb, path);
            p.Value = 80;
            lb = searchReplace(lb,search,replace,isregex,path);
            p.Value = 100;
            return lb;
        }
        private ListBox removeNumbers(ListBox lb, string path)
        {
            Regex r = new Regex(@"[0-9]+");
            string oldname, newname;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                oldname = lb.Items[i].ToString();
                newname = r.Replace(lb.Items[i].ToString(), "");
                renameFile(path, oldname, newname);
                lb.Items[i] = newname;
            }
            return lb;
        }

        private ListBox removeSpaces(ListBox lb, string path)
        {
            Regex r = new Regex(@"\s+");
            string oldname, newname;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                oldname = lb.Items[i].ToString();
                newname = r.Replace(lb.Items[i].ToString(), "");
                renameFile(path, oldname, newname);
                lb.Items[i] = newname;
            }
            return lb;
        }
        private ListBox toUppercase(ListBox lb, string path)
        {
            string oldname, newname;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                string item = lb.Items[i].ToString().ToUpper();
                oldname = lb.Items[i].ToString();
                newname = item;
                renameFile(path, oldname, newname);
                lb.Items[i] = "";
                lb.Items[i] = item;
            }
            return lb;
        }
        private ListBox toLowercase(ListBox lb, string path)
        {
            string oldname, newname;
            for (int i = 0; i < lb.Items.Count; i++)
            {
                string item = lb.Items[i].ToString().ToLower();
                oldname = lb.Items[i].ToString();
                newname = item;
                renameFile(path, oldname, newname);
                lb.Items[i] = ""; 
                lb.Items[i] = item; 
            }
            return lb;
        }
        private ListBox searchReplace(ListBox lb, string search, string replace, bool isregex, string path)
        {
            if (isregex && search.Trim().Length > 0 )
            {
                Regex r = new Regex(search);
                for (int i = 0; i < lb.Items.Count; i++)
                {   
                    string oldname = lb.Items[i].ToString();
                    string newname = r.Replace(lb.Items[i].ToString(), replace);
                    renameFile(path, oldname, newname);
                    lb.Items[i] = newname;
                }

            }
            else {
                for (int i = 0; i < lb.Items.Count; i++)
                {
                    lb.Items[i] = lb.Items[i].ToString().Replace("\\"+search+"\\", replace);
                }
            }
            return lb;
        }
        private void renameFile(string path, string currname, string newname)
        {
            try
            {
                File.Move(path + currname, path + newname);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message.ToString(), "Something went wrong", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }

        }
    }
}
