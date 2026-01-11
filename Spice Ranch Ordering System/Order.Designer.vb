<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.HScrollBar1 = New System.Windows.Forms.HScrollBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.quantitylbl = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.main = New System.Windows.Forms.PictureBox()
        Me.Mag = New System.Windows.Forms.PictureBox()
        Me.bgr2 = New System.Windows.Forms.PictureBox()
        Me.bgr3 = New System.Windows.Forms.PictureBox()
        Me.brg1 = New System.Windows.Forms.PictureBox()
        Me.prawn = New System.Windows.Forms.PictureBox()
        Me.Korma = New System.Windows.Forms.PictureBox()
        Me.Pep = New System.Windows.Forms.PictureBox()
        Me.Tikka = New System.Windows.Forms.PictureBox()
        Me.Veg = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.main, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Mag, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgr2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bgr3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.brg1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.prawn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Korma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Pep, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Tikka, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Veg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ComboBox1
        '
        Me.ComboBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(12, 328)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(358, 28)
        Me.ComboBox1.TabIndex = 3
        Me.ComboBox1.Text = "Select A Food Item"
        '
        'HScrollBar1
        '
        Me.HScrollBar1.Location = New System.Drawing.Point(120, 370)
        Me.HScrollBar1.Name = "HScrollBar1"
        Me.HScrollBar1.Size = New System.Drawing.Size(253, 20)
        Me.HScrollBar1.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(-1, 370)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "QUANTITY:"
        '
        'quantitylbl
        '
        Me.quantitylbl.AutoSize = True
        Me.quantitylbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quantitylbl.Location = New System.Drawing.Point(87, 370)
        Me.quantitylbl.Name = "quantitylbl"
        Me.quantitylbl.Size = New System.Drawing.Size(18, 20)
        Me.quantitylbl.TabIndex = 6
        Me.quantitylbl.Text = "0"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(9, 403)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(361, 39)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Add To Basket"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(70, 448)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 71)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Select Another Item"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(151, 448)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 71)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(232, 448)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 71)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "View Basket"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Spice_Ranch_Ordering_System.My.Resources.Resources._1454946
        Me.PictureBox3.Location = New System.Drawing.Point(9, 494)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(47, 50)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 21
        Me.PictureBox3.TabStop = False
        '
        'main
        '
        Me.main.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.Untitled
        Me.main.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.main.Location = New System.Drawing.Point(12, 80)
        Me.main.Name = "main"
        Me.main.Size = New System.Drawing.Size(358, 242)
        Me.main.TabIndex = 20
        Me.main.TabStop = False
        '
        'Mag
        '
        Me.Mag.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.images
        Me.Mag.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Mag.Location = New System.Drawing.Point(12, 80)
        Me.Mag.Name = "Mag"
        Me.Mag.Size = New System.Drawing.Size(358, 242)
        Me.Mag.TabIndex = 19
        Me.Mag.TabStop = False
        '
        'bgr2
        '
        Me.bgr2.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.r9rgahse
        Me.bgr2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bgr2.Location = New System.Drawing.Point(12, 80)
        Me.bgr2.Name = "bgr2"
        Me.bgr2.Size = New System.Drawing.Size(358, 242)
        Me.bgr2.TabIndex = 18
        Me.bgr2.TabStop = False
        '
        'bgr3
        '
        Me.bgr3.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.mu2h74nw
        Me.bgr3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bgr3.Location = New System.Drawing.Point(12, 80)
        Me.bgr3.Name = "bgr3"
        Me.bgr3.Size = New System.Drawing.Size(358, 242)
        Me.bgr3.TabIndex = 17
        Me.bgr3.TabStop = False
        '
        'brg1
        '
        Me.brg1.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.huy0e9pq
        Me.brg1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.brg1.Location = New System.Drawing.Point(12, 80)
        Me.brg1.Name = "brg1"
        Me.brg1.Size = New System.Drawing.Size(358, 242)
        Me.brg1.TabIndex = 16
        Me.brg1.TabStop = False
        '
        'prawn
        '
        Me.prawn.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources._230901KINGPRAWNTANDOORI06024_eb340c9
        Me.prawn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.prawn.Location = New System.Drawing.Point(12, 80)
        Me.prawn.Name = "prawn"
        Me.prawn.Size = New System.Drawing.Size(358, 242)
        Me.prawn.TabIndex = 15
        Me.prawn.TabStop = False
        '
        'Korma
        '
        Me.Korma.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.chicken_korma_recipe
        Me.Korma.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Korma.Location = New System.Drawing.Point(12, 80)
        Me.Korma.Name = "Korma"
        Me.Korma.Size = New System.Drawing.Size(358, 242)
        Me.Korma.TabIndex = 14
        Me.Korma.TabStop = False
        '
        'Pep
        '
        Me.Pep.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.Peporoni
        Me.Pep.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Pep.Location = New System.Drawing.Point(12, 80)
        Me.Pep.Name = "Pep"
        Me.Pep.Size = New System.Drawing.Size(358, 242)
        Me.Pep.TabIndex = 13
        Me.Pep.TabStop = False
        '
        'Tikka
        '
        Me.Tikka.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.Tikka
        Me.Tikka.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Tikka.Location = New System.Drawing.Point(12, 80)
        Me.Tikka.Name = "Tikka"
        Me.Tikka.Size = New System.Drawing.Size(358, 242)
        Me.Tikka.TabIndex = 12
        Me.Tikka.TabStop = False
        '
        'Veg
        '
        Me.Veg.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.veggie_pizza_side_view_out_of_oven_720x480
        Me.Veg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Veg.Location = New System.Drawing.Point(12, 80)
        Me.Veg.Name = "Veg"
        Me.Veg.Size = New System.Drawing.Size(358, 242)
        Me.Veg.TabIndex = 11
        Me.Veg.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources._146817
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Location = New System.Drawing.Point(309, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(61, 62)
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Spice_Ranch_Ordering_System.My.Resources.Resources.Designer
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 62)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 547)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.main)
        Me.Controls.Add(Me.Mag)
        Me.Controls.Add(Me.bgr2)
        Me.Controls.Add(Me.bgr3)
        Me.Controls.Add(Me.brg1)
        Me.Controls.Add(Me.prawn)
        Me.Controls.Add(Me.Korma)
        Me.Controls.Add(Me.Pep)
        Me.Controls.Add(Me.Tikka)
        Me.Controls.Add(Me.Veg)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.quantitylbl)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.HScrollBar1)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Order"
        Me.Text = "Order"
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.main, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Mag, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgr2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bgr3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.brg1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.prawn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Korma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Pep, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Tikka, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Veg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents HScrollBar1 As HScrollBar
    Friend WithEvents Label1 As Label
    Friend WithEvents quantitylbl As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Veg As PictureBox
    Friend WithEvents Tikka As PictureBox
    Friend WithEvents Pep As PictureBox
    Friend WithEvents Korma As PictureBox
    Friend WithEvents prawn As PictureBox
    Friend WithEvents brg1 As PictureBox
    Friend WithEvents bgr3 As PictureBox
    Friend WithEvents bgr2 As PictureBox
    Friend WithEvents Mag As PictureBox
    Friend WithEvents main As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
End Class
