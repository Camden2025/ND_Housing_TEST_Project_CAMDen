namespace ND_Housing_TEST_Project_CAMDen
{
    public partial class ValueDisplayFormWhenDoubleClicked
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
        public ValueDisplayFormWhenDoubleClicked(int row,int col,string value)
        {
            InitializeComponent();
            label1.Text = value;
            this.Text = $"Cell({row + 1}, {col + 1})";
        }

        #region Windows Form Designer generated code

      
        private void InitializeComponent()
        {
            label1 = new Label();
            OK_Button = new Button();
            SuspendLayout();

            // label1 – Displays the value of the selected cell. Below is the code for its visual settings like font size, alignment, anchoring, etc.

            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(382, 203);
            label1.TabIndex = 0;
            label1.Text = "label1";
            label1.TextAlign = ContentAlignment.MiddleCenter;

            // OK_Button – Closes the cell popup window. The code for this is in Form1.cs.
            // Below are the visual display settings like font size, alignment, anchoring, etc.
            OK_Button.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OK_Button.Location = new Point(139, 138);
            OK_Button.Name = "OK_Button";
            OK_Button.Size = new Size(102, 34);
            OK_Button.TabIndex = 1;
            OK_Button.Text = "OK";
            OK_Button.UseVisualStyleBackColor = true;
            OK_Button.Click += button1_Click;

            // ValueDisplayFormWhenDoubleClicked – Code triggered from Form1.cs when a cell is double-clicked; opens a window showing the cell’s value centered
            // with an OK button that closes the window (also closes on Esc or Enter).
            // Visual display settings like font size, alignment, anchoring, etc.

            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(382, 203);
            Controls.Add(OK_Button);
            Controls.Add(label1);
            Name = "ValueDisplayFormWhenDoubleClicked";
            Text = "ValueDisplayFormWhenDoubleClicked";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button OK_Button;
    }
}