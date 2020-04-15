using mergePDFsUI;
using splitPDFsUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PDF_manipulation_tool
{
    public partial class pdfManipulationTool : Form
    {
        SplitPDFtool pdfDoc;
        List<string> filesToMerge = new List<string>();

        // event handler to add and remove based on focused component
        System.EventHandler startPageIndexEvent;
        System.EventHandler endPageIndexEvent;
        System.EventHandler startPageSliderEvent;
        System.EventHandler endPageSliderEvent;

        public pdfManipulationTool()
        {
            InitializeComponent();
        }

        ////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// Merge PDF section
        /// 
        ///////////////////////////////////////////////////////////////////////////////////

        private void SelecPdfToMerge(object sender, EventArgs e)
        {
            // see https://stackoverflow.com/questions/24449988/how-to-get-file-path-from-openfiledialog-and-folderbrowserdialog/24450050
            // see https://www.guru99.com/c-sharp-windows-forms-application.html
            OpenFileDialog fDialog = new OpenFileDialog();
            fDialog.Title = "Get filesToMerge to merge...";
            fDialog.Multiselect = true;

            if (fDialog.ShowDialog() == DialogResult.OK)
            {
                string[] fNames = fDialog.FileNames;
                List<string> newfilesToMerge = new List<string>(fNames);

                newfilesToMerge.ForEach(file =>
                {
                    string[] temp = file.Split('\\');
                    this.fileList.Items.Add(temp[temp.Length - 1]);
                    filesToMerge.Add(file);
                });

                this.removeFiles.Enabled = true;
                this.moveFileDown.Enabled = true;
                this.moveFileUp.Enabled = true;
                this.mergeButton.Enabled = true;
            }
        }

        private void removePdfFromList(object sender, EventArgs e)
        {
            if (filesToMerge.Count > 1)
            {
                int selectedIndex = this.fileList.SelectedIndex;
                if (selectedIndex > 0)
                {
                    if (selectedIndex != filesToMerge.Count - 1)
                    {
                        filesToMerge.RemoveAt(selectedIndex);
                        this.fileList.Items.RemoveAt(selectedIndex);

                        this.fileList.SetSelected(selectedIndex, true);
                    }
                    else
                    {
                        filesToMerge.RemoveAt(selectedIndex);
                        this.fileList.Items.RemoveAt(selectedIndex);

                        this.fileList.SetSelected(selectedIndex - 1, true);
                    }
                }
            }
            else if (filesToMerge.Count == 1)
            {
                filesToMerge.RemoveAt(0);
                this.fileList.Items.RemoveAt(0);

                this.removeFiles.Enabled = false;
                this.moveFileDown.Enabled = false;
                this.moveFileUp.Enabled = false;
                this.mergeButton.Enabled = false;
            }
        }

        private void moveFileUp_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.fileList.SelectedIndex;

            if (selectedIndex != 0)
            {
                string fullFileName = filesToMerge[selectedIndex];
                string fileName = this.fileList.Items[selectedIndex].ToString();

                filesToMerge.RemoveAt(selectedIndex);
                filesToMerge.Insert(selectedIndex - 1, fullFileName);

                fileList.Items.RemoveAt(selectedIndex);
                fileList.Items.Insert(selectedIndex - 1, fileName);

                fileList.SetSelected(selectedIndex - 1, true);
            }
        }

        private void moveFileDown_Click(object sender, EventArgs e)
        {
            int selectedIndex = this.fileList.SelectedIndex;

            if (selectedIndex != (filesToMerge.Count - 1))
            {
                string fullFileName = filesToMerge[selectedIndex];
                string fileName = this.fileList.Items[selectedIndex].ToString();

                filesToMerge.RemoveAt(selectedIndex);
                filesToMerge.Insert(selectedIndex + 1, fullFileName);

                fileList.Items.RemoveAt(selectedIndex);
                fileList.Items.Insert(selectedIndex + 1, fileName);

                fileList.SetSelected(selectedIndex + 1, true);
            }
        }

        private void mergeButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sDialog = new SaveFileDialog();
            sDialog.Title = "Save file to...";
            sDialog.DefaultExt = ".pdf";
            sDialog.Filter = "Pdf (*.pdf)|*.pdf";

            if (sDialog.ShowDialog() == DialogResult.OK)
            {
                int success = MergePdfTool.MergePDF(filesToMerge, sDialog.FileName);
                Console.WriteLine("Merge!");

                if (success == -1)
                {
                    MessageBox.Show("Could not complete task. The file is probably opened or in use");
                }
            }

        }

        ////////////////////////////////////////////////////////////////////////////////////
        /// 
        /// Split PDF section
        /// 
        ///////////////////////////////////////////////////////////////////////////////////

        private void browse_Click(object sender, EventArgs e)
        {
            // Get file and its properties to set values of the components
            OpenFileDialog oDialog = new OpenFileDialog();
            oDialog.Filter = "PDF filesToMerge (*.pdf)|*.pdf";

            if (oDialog.ShowDialog() == DialogResult.OK)
            {
                string filename = oDialog.FileName;

                pdfDoc = new SplitPDFtool(filename);

                string[] filePath = filename.Split('\\');

                // labelling...
                this.filename.Text = filePath[filePath.Length - 1];

                this.startPageSlider.Maximum = pdfDoc.NumPages;
                this.startPageSlider.Value = 1;
                this.startPageIndex.Text = "1";
                this.startPageIndex.Value = 1;

                this.endPageSlider.Maximum = pdfDoc.NumPages;
                this.endPageIndex.Text = pdfDoc.NumPages.ToString();
                this.endPageIndex.Value = pdfDoc.NumPages;
                this.endPageSlider.Value = pdfDoc.NumPages;
                this.endPageIndex.Text = pdfDoc.NumPages.ToString();

                this.specificPageSelectionWindow.Items.Clear();
                for (int i = 1; i <= pdfDoc.NumPages; i++)
                {
                    this.specificPageSelectionWindow.Items.Add(i);
                    this.specificPageSelectionWindow.SetItemChecked(this.specificPageSelectionWindow.Items.Count - 1, true);
                }
                this.selectAllCheckBox.Checked = true;

                // enabling of the components
                this.startPageSlider.Enabled = true;
                this.endPageSlider.Enabled = true;
                this.startPageLabel.Enabled = true;
                this.endPageLabel.Enabled = true;
                this.startPageIndex.Enabled = true;
                this.endPageIndex.Enabled = true;
                this.rangeOfPagesRadioBtn.Enabled = true;
                this.specificPageSelectionRadioBtn.Enabled = true;
                this.splitAndSave.Enabled = true;
            }

        }

        private void startPageIndex_ValueChanged(object sender, EventArgs e)
        /* When information from start page label changes, update start 
         * page slider and end page index and slider if needed */
        {
            int startPageNum = Decimal.ToInt32(this.startPageIndex.Value);
            if (startPageNum <= pdfDoc.NumPages)
            {
                // start page slider
                if (startPageNum != 0)
                {
                    this.startPageSlider.Value = startPageNum;
                }
                else
                {
                    this.startPageSlider.Value = 1;
                    this.startPageIndex.Text = startPageIndex.ToString();
                }

                int endPageIndex = int.Parse(this.endPageIndex.Text);
                if (endPageIndex < startPageNum)
                {
                    // end page index
                    this.endPageIndex.Text = startPageIndex.ToString();
                    this.endPageIndex.Value = startPageIndex.Value;


                    // end page slider
                    this.endPageSlider.Value = startPageNum;
                }
            }
            else
            {
                this.startPageIndex.Text = pdfDoc.NumPages.ToString();
                this.startPageSlider.Value = pdfDoc.NumPages;
                this.endPageIndex.Text = pdfDoc.NumPages.ToString();
                this.endPageSlider.Value = pdfDoc.NumPages;
            }
        }

        private void endPageIndex_ValueChanged(object sender, EventArgs e)
        /* When information from end page label changes, update end 
         * page slider and start page index and slider if needed */
        {
            int endPageNum = Decimal.ToInt32(this.endPageIndex.Value);
            // end page slider
            if (endPageNum != 0)
            {
                this.endPageSlider.Value = endPageNum;
            }
            else
            {
                this.endPageSlider.Value = 1;
                this.endPageIndex.Text = "1";
            }

            int startPageNum = int.Parse(this.startPageIndex.Text);
            if (endPageNum < startPageNum)
            {
                // start page index
                this.startPageIndex.Text = endPageNum.ToString();

                // start page slider
                this.startPageSlider.Value = endPageNum;
            }
        }

        private void startPageSlider_Scroll(object sender, EventArgs e)
        /* When information from start page slider changes, update start 
         * page index and end page index and slider if needed */
        {
            // start page index
            this.startPageIndex.Text = this.startPageSlider.Value.ToString();

            int endPageNum = this.endPageSlider.Value;
            if (this.startPageSlider.Value > endPageNum)
            {
                // end page index
                this.endPageIndex.Value = this.startPageSlider.Value;

                // end page slider
                this.endPageSlider.Value = this.startPageSlider.Value;
            }
        }

        private void endPageSlider_Scroll(object sender, EventArgs e)
        /* When information from end page slider changes, update end 
         * page index and start page index and slider if needed */
        {
            // end page index
            this.endPageIndex.Text = this.endPageSlider.Value.ToString();

            int startPageNum = this.startPageSlider.Value;
            if (this.endPageSlider.Value < startPageNum)
            {
                // start page index
                this.startPageIndex.Value = this.endPageSlider.Value;

                // start page slider
                this.startPageSlider.Value = this.endPageSlider.Value;
            }
        }

        private void textbox_keypress(object sender, KeyPressEventArgs e)
        /* Useful if entry labels must only receive numbered inputs */
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == (char)8))
            {
                e.Handled = true;
            }
        }

        private void startPageIndex_focus(object sender, EventArgs e)
        /* Add events to start page index when focused */
        {
            startPageIndexEvent = new System.EventHandler(startPageIndex_ValueChanged);
            this.startPageIndex.TextChanged += startPageIndexEvent;
        }

        private void startPageIndex_unfocus(object sender, EventArgs e)
        /* Remove events to start page index when defocused */
        {
            this.startPageIndex.TextChanged -= startPageIndexEvent;
        }

        private void startPageSlider_focus(object sender, EventArgs e)
        /* Add events to start page slider when focused */
        {
            startPageSliderEvent = new System.EventHandler(startPageSlider_Scroll);
            this.startPageSlider.Scroll += this.startPageSliderEvent;
        }

        private void startPageSlider_unfocus(object sender, EventArgs e)
        /* Remove events to start page slider when defocused */
        {
            this.startPageSlider.Scroll -= startPageSliderEvent;
        }

        private void endPageIndex_focus(object sender, EventArgs e)
        /* Add events to end page index when focused */
        {
            endPageIndexEvent = new System.EventHandler(endPageIndex_ValueChanged);
            this.endPageIndex.TextChanged += endPageIndexEvent;
        }

        private void endPageIndex_unfocus(object sender, EventArgs e)
        /* Remove events to end page index when defocused */
        {
            this.endPageIndex.TextChanged -= endPageIndexEvent;
        }

        private void endPageSlider_focus(object sender, EventArgs e)
        /* Add events to end page slider when focused */
        {
            endPageSliderEvent = new System.EventHandler(endPageSlider_Scroll);
            this.endPageSlider.Scroll += endPageSliderEvent;
        }

        private void endPageSlider_unfocus(object sender, EventArgs e)
        /* Remove events to end page index when defocused */
        {
            this.endPageSlider.Scroll -= endPageSliderEvent;
        }

        private void rangeOfPagesRadioBtn_CheckedChanged(object sender, EventArgs e)
        /* Enable range of page selection components */
        {
            this.startPageSlider.Enabled = true;
            this.endPageSlider.Enabled = true;
            this.startPageLabel.Enabled = true;
            this.endPageLabel.Enabled = true;
            this.startPageIndex.Enabled = true;
            this.endPageIndex.Enabled = true;
            this.selectAllCheckBox.Enabled = false;
            this.specificPageSelectionWindow.Enabled = false;
        }

        private void specificPageSelectionRadioBtn_CheckedChanged(object sender, EventArgs e)
        /* Enable specific page selection components */
        {
            this.startPageSlider.Enabled = false;
            this.endPageSlider.Enabled = false;
            this.startPageLabel.Enabled = false;
            this.endPageLabel.Enabled = false;
            this.startPageIndex.Enabled = false;
            this.endPageIndex.Enabled = false;
            this.selectAllCheckBox.Enabled = true;
            this.specificPageSelectionWindow.Enabled = true;
        }

        private void splitAndSave_Click(object sender, EventArgs e)
        /* Produce new document with page selection wether it is range or selection of pages */
        {
            SaveFileDialog sDialog = new SaveFileDialog();
            sDialog.Filter = "PDF filesToMerge (*.pdf)|*.pdf";

            if (sDialog.ShowDialog() == DialogResult.OK)
            {
                string outputFilename = sDialog.FileName;
                if (this.rangeOfPagesRadioBtn.Checked)
                {
                    int minPage = Decimal.ToInt16(startPageIndex.Value);
                    int maxPage = Decimal.ToInt16(endPageIndex.Value);
                    List<int> pageRange = Enumerable.Range(minPage, maxPage - minPage + 1).ToList();
                    int success = pdfDoc.createPdfFromPages(pageRange, outputFilename);
                    if (success == -1)
                    {
                        MessageBox.Show("Could not complete task. The file is probably opened or in use");
                    }
                }
                else
                {
                    List<int> pageSelection = new List<int>();
                    for (int i = 0; i < pdfDoc.NumPages; i++)
                    {
                        if (this.specificPageSelectionWindow.GetItemChecked(i))
                        {
                            pageSelection.Add(i + 1);
                        }
                    }
                    int success = pdfDoc.createPdfFromPages(pageSelection, outputFilename);
                    if (success == -1)
                    {
                        MessageBox.Show("Could not complete task. The file is probably opened or in use");
                    }
                }

            }
        }

        private void selectAllCheckBox_CheckedChanged(object sender, EventArgs e)
        /* Checks or unchecks all page selection for specific page selection option */
        {
            if (selectAllCheckBox.Checked)
            {
                for (int i = 0; i < pdfDoc.NumPages; i++)
                {
                    this.specificPageSelectionWindow.SetItemChecked(i, true);
                }
            }
            else
            {
                for (int i = 0; i < pdfDoc.NumPages; i++)
                {
                    this.specificPageSelectionWindow.SetItemChecked(i, false);
                }
            }
        }
    }
}
