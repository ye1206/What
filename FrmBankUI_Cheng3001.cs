using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4Bank_Cheng3001_220504
{
    public partial class FrmBankUI_Cheng3001 : Form
    {
        protected int TextBoxCount { get; set; } = 4; // number of TextBoxes
                                                                                // enumeration constants specify TextBox indices
        public enum TextBoxIndices { Account, First, Last, Balance } 
        
        // parameterless constructor
        public FrmBankUI_Cheng3001()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            // iterate through every Control on form
            foreach (Control guiControl in Controls)
            {
                (guiControl as TextBox)?.Clear();   // if Control is TextBox, clear it
            }
        } //end of ClearTextBoxes

        // set text box values to string-array values
        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)  // determine whether string array has correct length
            {
                // throw exception if not correct length
                throw (new ArgumentException($"There must be {TextBoxCount} strings in the array",nameof(values)));
            }
            else // set array values if array has correct length
            {
                // set array values to TextBox values
                TxtAccount.Text = values[(int)TextBoxIndices.Account];
                TxtFirstName.Text = values[(int)TextBoxIndices.First];
                TxtLastName.Text = values[(int)TextBoxIndices.Last];
                TxtBalance.Text = values[(int)TextBoxIndices.Balance];
            }
        } //end of SetTextBoxValues

        // return TextBox values as string array
        public string[] GetTextBoxValues()
        {
            return new string[] {
            TxtAccount.Text, TxtFirstName.Text,
            TxtLastName.Text, TxtBalance.Text};
        } //end of GetTextBoxValues
    } //end of clss FrmBankUI
}
