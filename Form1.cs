 private void button2_Click(object sender, EventArgs e)
        {
            string a = textBox1.Text;
            if (Search(temp.root,a)=="Found")
            {
                label4.Text = "Word found";
            }
            else
            {
                label4.Text = "not Found";
            }
        }
        public string Search(Node a, string x)
        {

            if (a == null)
                return "Not Found";
            else if (x.CompareTo(a.data) < 0)
            {
                return Search(a.left, x);
            }
            else if (x.CompareTo(a.data) > 0)
            {
                return Search(a.right, x);
            }

            return "Found";



           
        }
    }