using System.Data;

namespace MoodleQuizCreator
{
    public partial class FormEditQuestion : Form
    {
        public bool QuestionDataChanged { get; set; } = false;

        public DataRow QuestionRow { get; set; }

        public Subject QuestionSubject { get; set; }

        private bool hasChanged;

        public FormEditQuestion()
        {
            InitializeComponent();
        }

        private void FormEditQuestion_Load(object sender, EventArgs e)
        {
            //load items into topic combobox
            foreach (SubjectTopic topic in QuestionSubject.Items)
            {
                comboBoxTopic.Items.Add(topic.name);
            }

            //load the data into the form
            UpdateFormData();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            //Cancel
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            //Return to the form and trigger save
            if (hasChanged)
            {
                if (MessageBox.Show("Question data changed, update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateQuestion();
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ButtonPaste_Click(object sender, EventArgs e)
        {
            if (Clipboard.ContainsImage())
            {
                pictureBoxImage.Image = Clipboard.GetImage();
                QuestionDataChanged = true;
                hasChanged = true;
            }
        }

        private void ButtonNext_Click(object sender, EventArgs e)
        {
            if (hasChanged)
            {
                if (MessageBox.Show("Question data changed, update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateQuestion();
                }
            }
            
            DataGridView dgv = (DataGridView)this.Owner.Controls["tabControlMain"].Controls["tabPageQuestionData"].Controls["dataGridViewQuestions"];
            int newIndex = dgv.CurrentRow.Index + 1;
            if (newIndex < dgv.Rows.Count - 1)
            {
                dgv.CurrentCell = dgv.Rows[newIndex].Cells[0];
                QuestionRow = ((DataRowView)dgv.CurrentRow.DataBoundItem).Row;
                dgv.ClearSelection();
                dgv.CurrentRow.Selected = true;
                UpdateFormData();
            }
        }

        private void ButtonBack_Click(object sender, EventArgs e)
        {
            if (hasChanged)
            {
                if (MessageBox.Show("Question data changed, update?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    UpdateQuestion();
                }
            }

            DataGridView dgv = (DataGridView)this.Owner.Controls["tabControlMain"].Controls["tabPageQuestionData"].Controls["dataGridViewQuestions"];
            int newIndex = dgv.CurrentRow.Index - 1;
            if (newIndex >= 0)
            {
                dgv.CurrentCell = dgv.Rows[newIndex].Cells[0];
                QuestionRow = ((DataRowView)dgv.CurrentRow.DataBoundItem).Row;
                dgv.ClearSelection();
                dgv.CurrentRow.Selected = true;
                UpdateFormData();
            }
        }

        private void ButtonUpdateQuestion_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)this.Owner.Controls["tabControlMain"].Controls["tabPageQuestionData"].Controls["dataGridViewQuestions"];
            int newIndex = dgv.CurrentRow.Index;
            UpdateQuestion();
            dgv.CurrentCell = dgv.Rows[newIndex].Cells[0];
            QuestionRow = ((DataRowView)dgv.CurrentRow.DataBoundItem).Row;
            dgv.ClearSelection();
            dgv.CurrentRow.Selected = true;
            UpdateFormData();
        }

        private void ButtonDeleteQuestion_Click(object sender, EventArgs e)
        {
            DataGridView dgv = (DataGridView)this.Owner.Controls["tabControlMain"].Controls["tabPageQuestionData"].Controls["dataGridViewQuestions"];
            dgv.Rows.RemoveAt(dgv.CurrentRow.Index);
            QuestionRow = ((DataRowView)dgv.CurrentRow.DataBoundItem).Row;
            dgv.ClearSelection();
            dgv.CurrentRow.Selected = true;
            UpdateFormData();
        }

        private void UpdateQuestion()
        {
            //update datarow
            QuestionRow["Question Type"] = "multichoice";
            QuestionRow["Question Topic"] = comboBoxTopic.Text;
            QuestionRow["Question Category"] = comboBoxCategory.Text;
            QuestionRow["Question Name"] = textBoxQuestionName.Text;
            QuestionRow["Question Image"] = ClassUtils.ImageToByte(pictureBoxImage.Image);
            QuestionRow["Question Answer"] = comboBoxAnswer.Text;
            hasChanged = false;
            UpdateFormData();
        }

        private void UpdateFormData()
        {
            //Unhook event handlers
            comboBoxTopic.SelectedValueChanged -= ComboBoxTopic_SelectedValueChanged;
            comboBoxCategory.SelectedValueChanged -= ComboBox_SelectedValueChanged;
            comboBoxAnswer.SelectedValueChanged -= ComboBox_SelectedValueChanged;
            textBoxQuestionName.TextChanged -= TextBoxQuestionData_TextChanged;

            //Set Form controls
            if (comboBoxTopic.Items.Contains(QuestionRow["Question Topic"].ToString()))
            {
                comboBoxTopic.Text = QuestionRow["Question Topic"].ToString();
                UpdateCategory();
            }
            textBoxQuestionName.Text = QuestionRow["Question Name"].ToString();
            pictureBoxImage.Image = ClassUtils.ByteToImage((byte[])QuestionRow["Question Image"]);
            comboBoxAnswer.Text = QuestionRow["Question Answer"].ToString();

            //Rehook event handlers
            comboBoxTopic.SelectedValueChanged += ComboBoxTopic_SelectedValueChanged;
            comboBoxCategory.SelectedValueChanged += ComboBox_SelectedValueChanged;
            comboBoxAnswer.SelectedValueChanged += ComboBox_SelectedValueChanged;
            textBoxQuestionName.TextChanged += TextBoxQuestionData_TextChanged;

            hasChanged = false;
        }

        private void TextBoxQuestionData_TextChanged(object sender, EventArgs e)
        {
            QuestionDataChanged = true;
            hasChanged = true;
        }

        private void UpdateCategory()
        {
            comboBoxCategory.Items.Clear();

            SubjectTopic selectedTopic = QuestionSubject.Items.FirstOrDefault(item => item.name == comboBoxTopic.Text);
            foreach (SubjectTopicCategory category in selectedTopic!.Category)
            {
                comboBoxCategory.Items.Add(category.name);
            }

            if (comboBoxCategory.Items.Contains(QuestionRow["Question Category"].ToString()))
            {
                comboBoxCategory.Text = QuestionRow["Question Category"].ToString();
            }
            else
            {
                comboBoxCategory.Text = selectedTopic.Category[0].name;
            }
        }

        private void ComboBoxTopic_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateCategory();
            QuestionDataChanged = true;
            hasChanged = true;
        }

        private void ComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            QuestionDataChanged = true;
            hasChanged = true;
        }
    }
}