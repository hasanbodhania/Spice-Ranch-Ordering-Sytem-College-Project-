<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class basket
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Food_Item = New System.Windows.Forms.ListBox()
        Me.Food_Quantity = New System.Windows.Forms.ListBox()
        Me.Food_Price = New System.Windows.Forms.ListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.Designer
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 62)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Food_Item
        '
        Me.Food_Item.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Food_Item.FormattingEnabled = True
        Me.Food_Item.Location = New System.Drawing.Point(12, 117)
        Me.Food_Item.Name = "Food_Item"
        Me.Food_Item.Size = New System.Drawing.Size(221, 275)
        Me.Food_Item.TabIndex = 4
        '
        'Food_Quantity
        '
        Me.Food_Quantity.FormattingEnabled = True
        Me.Food_Quantity.Location = New System.Drawing.Point(239, 117)
        Me.Food_Quantity.Name = "Food_Quantity"
        Me.Food_Quantity.Size = New System.Drawing.Size(63, 277)
        Me.Food_Quantity.TabIndex = 5
        '
        'Food_Price
        '
        Me.Food_Price.FormattingEnabled = True
        Me.Food_Price.Location = New System.Drawing.Point(308, 117)
        Me.Food_Price.Name = "Food_Price"
        Me.Food_Price.Size = New System.Drawing.Size(63, 277)
        Me.Food_Price.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(254, 21)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 53)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Back To Order Form"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(71, 413)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Total Price: "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 419)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 25)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "£0.00"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(12, 466)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(358, 60)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Checkout"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 77)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(121, 31)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Basket: "
        '
        'basket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 547)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Food_Price)
        Me.Controls.Add(Me.Food_Quantity)
        Me.Controls.Add(Me.Food_Item)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "basket"
        Me.Text = "basket"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Food_Quantity As ListBox
    Friend WithEvents Food_Price As ListBox
    Friend WithEvents Button1 As Button
    Public WithEvents Food_Item As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
End Class
