namespace TodosApp
{
    partial class TodoApp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.todoTitle = new System.Windows.Forms.Label();
            this.todosLabel = new System.Windows.Forms.Label();
            this.todoCheckBox = new System.Windows.Forms.CheckedListBox();
            this.saveTodoButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.todoBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.titleLabel.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 103);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(84, 31);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Todo:";
            // 
            // todoTitle
            // 
            this.todoTitle.AutoSize = true;
            this.todoTitle.Cursor = System.Windows.Forms.Cursors.No;
            this.todoTitle.Font = new System.Drawing.Font("Verdana", 31.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoTitle.Location = new System.Drawing.Point(46, 9);
            this.todoTitle.Name = "todoTitle";
            this.todoTitle.Size = new System.Drawing.Size(767, 65);
            this.todoTitle.TabIndex = 4;
            this.todoTitle.Text = "Welcome to Todos App!!!";
            // 
            // todosLabel
            // 
            this.todosLabel.AutoSize = true;
            this.todosLabel.Cursor = System.Windows.Forms.Cursors.No;
            this.todosLabel.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todosLabel.Location = new System.Drawing.Point(12, 180);
            this.todosLabel.Name = "todosLabel";
            this.todosLabel.Size = new System.Drawing.Size(186, 35);
            this.todosLabel.TabIndex = 5;
            this.todosLabel.Text = "Your Todos:";
            // 
            // todoCheckBox
            // 
            this.todoCheckBox.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoCheckBox.FormattingEnabled = true;
            this.todoCheckBox.Location = new System.Drawing.Point(18, 229);
            this.todoCheckBox.Name = "todoCheckBox";
            this.todoCheckBox.Size = new System.Drawing.Size(879, 400);
            this.todoCheckBox.TabIndex = 6;
            this.todoCheckBox.SelectedIndexChanged += new System.EventHandler(this.UpdateTodos);
            // 
            // saveTodoButton
            // 
            this.saveTodoButton.BackColor = System.Drawing.Color.LightGreen;
            this.saveTodoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.saveTodoButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveTodoButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveTodoButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveTodoButton.Location = new System.Drawing.Point(431, 92);
            this.saveTodoButton.Name = "saveTodoButton";
            this.saveTodoButton.Size = new System.Drawing.Size(174, 45);
            this.saveTodoButton.TabIndex = 7;
            this.saveTodoButton.Text = "Add Todo";
            this.saveTodoButton.UseVisualStyleBackColor = false;
            this.saveTodoButton.Click += new System.EventHandler(this.AddTodo);
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.DeleteButton.BackColor = System.Drawing.Color.Crimson;
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteButton.Location = new System.Drawing.Point(611, 92);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(286, 45);
            this.DeleteButton.TabIndex = 8;
            this.DeleteButton.Text = "Delete Completed";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteCompleted);
            // 
            // todoBox
            // 
            this.todoBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.todoBox.Font = new System.Drawing.Font("Ink Free", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.todoBox.Location = new System.Drawing.Point(94, 99);
            this.todoBox.Name = "todoBox";
            this.todoBox.Size = new System.Drawing.Size(331, 35);
            this.todoBox.TabIndex = 9;
            this.todoBox.Text = "";
            // 
            // TodoApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(909, 655);
            this.Controls.Add(this.todoBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.saveTodoButton);
            this.Controls.Add(this.todoCheckBox);
            this.Controls.Add(this.todosLabel);
            this.Controls.Add(this.todoTitle);
            this.Controls.Add(this.titleLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "TodoApp";
            this.Text = "Todos App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label todoTitle;
        private System.Windows.Forms.Label todosLabel;
        private System.Windows.Forms.CheckedListBox todoCheckBox;
        private System.Windows.Forms.Button saveTodoButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.RichTextBox todoBox;
    }
}

