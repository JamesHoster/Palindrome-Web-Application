using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PalindromeClass;
using Palindrome;
using System.Diagnostics;


namespace Palindrome.Web
{
    public partial class PalindromeText : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {  
        }
        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
        }
        protected void TextBox2_TextChanged(object sender, EventArgs e)
        { 
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string userInput = TextBox1.Text;
                Palindrome1 test = new Palindrome1();

                bool result = test.IsPalindrome(userInput);
                if (result == true)
                    TextBox2.Text = "Yes";
                else TextBox2.Text = "No";
            }
            catch (Exception ex)
            {
                TextBox2.Text = "Please Enter A Valid Response";
            }
        }
    }
}