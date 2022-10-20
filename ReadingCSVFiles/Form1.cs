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

namespace ReadingCSVFiles
{
    public partial class FormRecipeViewer : Form
    {
        StreamReader tsvFile;

        /// <summary>
        /// Form Constructor for FormPatientViewer.
        /// It only initialises the controls.
        /// </summary>
        public FormRecipeViewer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button click event for opening the tsv file. 
        /// The tsv file is expected to be located in the same directory as the executable.
        /// The name of the tsv file is RAW_recipes.txt
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                tsvFile = new StreamReader("RAW_recipes.txt");
                // Read First line and do nothing
                string line;
                if (ReadRecipeLineFromTSV(out line))
                {                    
                    // Read second line, first patient line and populate form
                    ReadRecipeLineFromTSV(out line);
                    PopulateForm(line);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Reads and returns a single line from the tsv file if the file is opened and 
        /// it is not at the end
        /// </summary>
        /// <param name="line">The line read</param>
        /// <returns>True if it successfully read the line, False if not</returns>
        private bool ReadRecipeLineFromTSV(out string line)
        {
            bool result = false;
            line = "";
            if ((tsvFile != null) && (!tsvFile.EndOfStream))
            {
                line = tsvFile.ReadLine();
                result = true;
            }
            else
            {
                MessageBox.Show("File has not been opened. Please open file before reading.");
            }
            return result;
        }

        /// <summary>
        /// Finds all strings within a string that are between ' '.
        /// For example if the input is "['aaaa','vvvvv','asfasf,asfasf,saf']"
        /// the output is an array of string with "aaaa" - "vvvvv" - "asfasf,asfasf,saf"
        /// </summary>
        /// <param name="substring">The string with all substrings</param>
        /// <returns>Array with all substrings in the string that are between ' and '</returns>
        private string[] ReadSubStringsbetweenQuotes(string substring)
        {
            List<string> steplist = new List<string>();
            string startchar = "'";
            string endchar = "'";
            int beginPos = substring.IndexOf(startchar, 0);
            while (beginPos >= 0)
            {
                int start = beginPos + startchar.Length;
                int stop = substring.IndexOf(endchar, start);
                if (stop < 0)
                {
                    break;
                }                    
                steplist.Add(substring.Substring(start, stop - start));
                beginPos = substring.IndexOf(startchar, stop + endchar.Length);
            }
            return steplist.ToArray();
        }

        /// <summary>
        /// Splits a string with using the comma 'tab' delimiter.
        /// Then populates each control in the form accordingly
        /// </summary>
        /// <param name="recipeDetails">The string containing the recipe information</param>
        private void PopulateForm(string recipeDetails)
        {
            // Clear controls from previous information
            listBoxIngredientsList.Items.Clear();
            listBoxRecipeSteps.Items.Clear();
            // Fill in all controls
            string[] recipe = recipeDetails.Split('\t');
            textBoxRecipeName.Text = recipe[0];
            textBoxRecipeMinutes.Text = recipe[1];
            int n_steps = int.Parse(recipe[2]);
            string[] steps = new string[n_steps];
            textBoxNumberSteps.Text = recipe[2];
            steps = ReadSubStringsbetweenQuotes(recipe[3]);
            listBoxRecipeSteps.Items.AddRange(steps);
            int n_ingredients = int.Parse(recipe[5]);
            string[] ingredients = new string[n_ingredients];
            textBoxNumberIngedients.Text = recipe[5];
            ingredients = ReadSubStringsbetweenQuotes(recipe[4]);
            listBoxIngredientsList.Items.AddRange(ingredients);
        }

        /// <summary>
        /// Reads the next recipe from the TSV file and updates the appropriate controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonNextRecord_Click(object sender, EventArgs e)
        {
            string recipeInfo;
            if (ReadRecipeLineFromTSV(out recipeInfo))
            {               
                PopulateForm(recipeInfo);
            }
        }
    }
}
