using System;
using System.Windows.Forms;

namespace DiamondLands
{
    public partial class MainForm : Form
    {
        DiamondSquare diamond;

        public MainForm()
        {
            InitializeComponent();
            seedUpDown.Maximum = int.MaxValue;
            seedUpDown.Minimum = int.MinValue;
            RenewSeed();
        }

        private bool EnableControls
        {
            set
            {
                generateButton.Enabled =
                    loopHCheckBox.Enabled = 
                    loopVCheckBox.Enabled =
                    renewSeedButton.Enabled =
                    seedUpDown.Enabled =
                    saveAsButton.Enabled =
                    alwaysNewCheckBox.Enabled =
                    mapSizeUpDown.Enabled = value;
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            if (alwaysNewCheckBox.Checked)
                RenewSeed();

            EnableControls = false;

            int size = (int)(((uint)mapSizeUpDown.Value).NextPower2());
            try
            {
                mapSizeUpDown.Value = size;
                size += 1;

                diamond = new DiamondSquare(size, (int)seedUpDown.Value);
                int min, max;
                diamond.Generate(out min, out max, 1000, loopHCheckBox.Checked, loopVCheckBox.Checked);

                canvasPanel.RefreshMap(diamond, min, max);
                canvasPanel.Invalidate();
            }
            catch(Exception ex)
            {
                MessageBox.Show(
                    "Lands out of window bounds." + Environment.NewLine +
                    ex.Message);
            }

            EnableControls = true;
        }

        private void RenewSeed()
        {
            seedUpDown.Value = Math.Abs((int)DateTime.UtcNow.Ticks);
        }

        private void saveAsButton_Click(object sender, EventArgs e)
        {
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
                canvasPanel.bitmap.Save(saveFileDialog.FileName);
        }

        private void renewSeedButton_Click(object sender, EventArgs e)
        {
            RenewSeed();
        }

        private void alwaysNewCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            renewSeedButton.Enabled = !alwaysNewCheckBox.Checked;
        }
    }
}
