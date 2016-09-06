<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardGameMainMenu
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
        Me.AddPlayerButton = New System.Windows.Forms.Button()
        Me.AddOneCardButton = New System.Windows.Forms.Button()
        Me.Add20CardsButton = New System.Windows.Forms.Button()
        Me.DisplayTotalsButton = New System.Windows.Forms.Button()
        Me.FindaCardButton = New System.Windows.Forms.Button()
        Me.DealaCardButton = New System.Windows.Forms.Button()
        Me.DealaCardtoeachPlayerButton = New System.Windows.Forms.Button()
        Me.RemoveaCardButton = New System.Windows.Forms.Button()
        Me.RemoveaCardfromeachPlayerButton = New System.Windows.Forms.Button()
        Me.CardDealerLabel = New System.Windows.Forms.Label()
        Me.PlayerDetailsLabel = New System.Windows.Forms.Label()
        Me.PlayerDetailsInformationLabel = New System.Windows.Forms.Label()
        Me.DeckofCardsLabel = New System.Windows.Forms.Label()
        Me.DeckofCardsInformationLabel = New System.Windows.Forms.Label()
        Me.SwapCardsButton = New System.Windows.Forms.Button()
        Me.CreateAutoDeckButton = New System.Windows.Forms.Button()
        Me.ShuffleCardsButton = New System.Windows.Forms.Button()
        Me.DisplayCardorPlayerHistory = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'AddPlayerButton
        '
        Me.AddPlayerButton.Location = New System.Drawing.Point(12, 52)
        Me.AddPlayerButton.Name = "AddPlayerButton"
        Me.AddPlayerButton.Size = New System.Drawing.Size(75, 34)
        Me.AddPlayerButton.TabIndex = 0
        Me.AddPlayerButton.Text = "Add Player"
        Me.AddPlayerButton.UseVisualStyleBackColor = True
        '
        'AddOneCardButton
        '
        Me.AddOneCardButton.Location = New System.Drawing.Point(93, 52)
        Me.AddOneCardButton.Name = "AddOneCardButton"
        Me.AddOneCardButton.Size = New System.Drawing.Size(75, 34)
        Me.AddOneCardButton.TabIndex = 1
        Me.AddOneCardButton.Text = "Add One Card"
        Me.AddOneCardButton.UseVisualStyleBackColor = True
        '
        'Add20CardsButton
        '
        Me.Add20CardsButton.Location = New System.Drawing.Point(174, 52)
        Me.Add20CardsButton.Name = "Add20CardsButton"
        Me.Add20CardsButton.Size = New System.Drawing.Size(75, 34)
        Me.Add20CardsButton.TabIndex = 2
        Me.Add20CardsButton.Text = "Add 20 Cards"
        Me.Add20CardsButton.UseVisualStyleBackColor = True
        '
        'DisplayTotalsButton
        '
        Me.DisplayTotalsButton.Location = New System.Drawing.Point(12, 92)
        Me.DisplayTotalsButton.Name = "DisplayTotalsButton"
        Me.DisplayTotalsButton.Size = New System.Drawing.Size(75, 34)
        Me.DisplayTotalsButton.TabIndex = 3
        Me.DisplayTotalsButton.Text = "Display Totals"
        Me.DisplayTotalsButton.UseVisualStyleBackColor = True
        '
        'FindaCardButton
        '
        Me.FindaCardButton.Location = New System.Drawing.Point(93, 92)
        Me.FindaCardButton.Name = "FindaCardButton"
        Me.FindaCardButton.Size = New System.Drawing.Size(75, 34)
        Me.FindaCardButton.TabIndex = 4
        Me.FindaCardButton.Text = "Find a Card"
        Me.FindaCardButton.UseVisualStyleBackColor = True
        '
        'DealaCardButton
        '
        Me.DealaCardButton.Location = New System.Drawing.Point(472, 52)
        Me.DealaCardButton.Name = "DealaCardButton"
        Me.DealaCardButton.Size = New System.Drawing.Size(75, 34)
        Me.DealaCardButton.TabIndex = 5
        Me.DealaCardButton.Text = "Deal a Card"
        Me.DealaCardButton.UseVisualStyleBackColor = True
        '
        'DealaCardtoeachPlayerButton
        '
        Me.DealaCardtoeachPlayerButton.Location = New System.Drawing.Point(553, 52)
        Me.DealaCardtoeachPlayerButton.Name = "DealaCardtoeachPlayerButton"
        Me.DealaCardtoeachPlayerButton.Size = New System.Drawing.Size(94, 34)
        Me.DealaCardtoeachPlayerButton.TabIndex = 6
        Me.DealaCardtoeachPlayerButton.Text = "Deal a Card to each Player"
        Me.DealaCardtoeachPlayerButton.UseVisualStyleBackColor = True
        '
        'RemoveaCardButton
        '
        Me.RemoveaCardButton.Location = New System.Drawing.Point(472, 92)
        Me.RemoveaCardButton.Name = "RemoveaCardButton"
        Me.RemoveaCardButton.Size = New System.Drawing.Size(75, 34)
        Me.RemoveaCardButton.TabIndex = 7
        Me.RemoveaCardButton.Text = "Remove a Card"
        Me.RemoveaCardButton.UseVisualStyleBackColor = True
        '
        'RemoveaCardfromeachPlayerButton
        '
        Me.RemoveaCardfromeachPlayerButton.Location = New System.Drawing.Point(553, 92)
        Me.RemoveaCardfromeachPlayerButton.Name = "RemoveaCardfromeachPlayerButton"
        Me.RemoveaCardfromeachPlayerButton.Size = New System.Drawing.Size(94, 34)
        Me.RemoveaCardfromeachPlayerButton.TabIndex = 8
        Me.RemoveaCardfromeachPlayerButton.Text = "Remove a Card from each Player"
        Me.RemoveaCardfromeachPlayerButton.UseVisualStyleBackColor = True
        '
        'CardDealerLabel
        '
        Me.CardDealerLabel.AutoSize = True
        Me.CardDealerLabel.Location = New System.Drawing.Point(257, 9)
        Me.CardDealerLabel.Name = "CardDealerLabel"
        Me.CardDealerLabel.Size = New System.Drawing.Size(63, 13)
        Me.CardDealerLabel.TabIndex = 9
        Me.CardDealerLabel.Text = "Card Dealer"
        '
        'PlayerDetailsLabel
        '
        Me.PlayerDetailsLabel.AutoSize = True
        Me.PlayerDetailsLabel.Location = New System.Drawing.Point(12, 139)
        Me.PlayerDetailsLabel.Name = "PlayerDetailsLabel"
        Me.PlayerDetailsLabel.Size = New System.Drawing.Size(71, 13)
        Me.PlayerDetailsLabel.TabIndex = 10
        Me.PlayerDetailsLabel.Text = "Player Details"
        '
        'PlayerDetailsInformationLabel
        '
        Me.PlayerDetailsInformationLabel.BackColor = System.Drawing.SystemColors.Info
        Me.PlayerDetailsInformationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PlayerDetailsInformationLabel.Location = New System.Drawing.Point(15, 161)
        Me.PlayerDetailsInformationLabel.Name = "PlayerDetailsInformationLabel"
        Me.PlayerDetailsInformationLabel.Size = New System.Drawing.Size(632, 100)
        Me.PlayerDetailsInformationLabel.TabIndex = 11
        '
        'DeckofCardsLabel
        '
        Me.DeckofCardsLabel.AutoSize = True
        Me.DeckofCardsLabel.Location = New System.Drawing.Point(12, 274)
        Me.DeckofCardsLabel.Name = "DeckofCardsLabel"
        Me.DeckofCardsLabel.Size = New System.Drawing.Size(75, 13)
        Me.DeckofCardsLabel.TabIndex = 12
        Me.DeckofCardsLabel.Text = "Deck of Cards"
        '
        'DeckofCardsInformationLabel
        '
        Me.DeckofCardsInformationLabel.BackColor = System.Drawing.SystemColors.Info
        Me.DeckofCardsInformationLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DeckofCardsInformationLabel.Location = New System.Drawing.Point(15, 296)
        Me.DeckofCardsInformationLabel.Name = "DeckofCardsInformationLabel"
        Me.DeckofCardsInformationLabel.Size = New System.Drawing.Size(632, 100)
        Me.DeckofCardsInformationLabel.TabIndex = 14
        '
        'SwapCardsButton
        '
        Me.SwapCardsButton.Location = New System.Drawing.Point(255, 52)
        Me.SwapCardsButton.Name = "SwapCardsButton"
        Me.SwapCardsButton.Size = New System.Drawing.Size(75, 34)
        Me.SwapCardsButton.TabIndex = 15
        Me.SwapCardsButton.Text = "Swap Cards"
        Me.SwapCardsButton.UseVisualStyleBackColor = True
        '
        'CreateAutoDeckButton
        '
        Me.CreateAutoDeckButton.Location = New System.Drawing.Point(255, 92)
        Me.CreateAutoDeckButton.Name = "CreateAutoDeckButton"
        Me.CreateAutoDeckButton.Size = New System.Drawing.Size(75, 34)
        Me.CreateAutoDeckButton.TabIndex = 16
        Me.CreateAutoDeckButton.Text = "Create Auto Deck"
        Me.CreateAutoDeckButton.UseVisualStyleBackColor = True
        '
        'ShuffleCardsButton
        '
        Me.ShuffleCardsButton.Location = New System.Drawing.Point(336, 52)
        Me.ShuffleCardsButton.Name = "ShuffleCardsButton"
        Me.ShuffleCardsButton.Size = New System.Drawing.Size(130, 34)
        Me.ShuffleCardsButton.TabIndex = 17
        Me.ShuffleCardsButton.Text = "Shuffle Cards"
        Me.ShuffleCardsButton.UseVisualStyleBackColor = True
        '
        'DisplayCardorPlayerHistory
        '
        Me.DisplayCardorPlayerHistory.Location = New System.Drawing.Point(336, 92)
        Me.DisplayCardorPlayerHistory.Name = "DisplayCardorPlayerHistory"
        Me.DisplayCardorPlayerHistory.Size = New System.Drawing.Size(130, 34)
        Me.DisplayCardorPlayerHistory.TabIndex = 18
        Me.DisplayCardorPlayerHistory.Text = "Display Card/Player History"
        Me.DisplayCardorPlayerHistory.UseVisualStyleBackColor = True
        '
        'CardGameMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(659, 406)
        Me.Controls.Add(Me.DisplayCardorPlayerHistory)
        Me.Controls.Add(Me.ShuffleCardsButton)
        Me.Controls.Add(Me.CreateAutoDeckButton)
        Me.Controls.Add(Me.SwapCardsButton)
        Me.Controls.Add(Me.DeckofCardsInformationLabel)
        Me.Controls.Add(Me.DeckofCardsLabel)
        Me.Controls.Add(Me.PlayerDetailsInformationLabel)
        Me.Controls.Add(Me.PlayerDetailsLabel)
        Me.Controls.Add(Me.CardDealerLabel)
        Me.Controls.Add(Me.RemoveaCardfromeachPlayerButton)
        Me.Controls.Add(Me.RemoveaCardButton)
        Me.Controls.Add(Me.DealaCardtoeachPlayerButton)
        Me.Controls.Add(Me.DealaCardButton)
        Me.Controls.Add(Me.FindaCardButton)
        Me.Controls.Add(Me.DisplayTotalsButton)
        Me.Controls.Add(Me.Add20CardsButton)
        Me.Controls.Add(Me.AddOneCardButton)
        Me.Controls.Add(Me.AddPlayerButton)
        Me.Name = "CardGameMainMenu"
        Me.Text = "INF20013 Business Systems Programming in .NET Assignment 2 StudentID: 700513X"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents AddPlayerButton As System.Windows.Forms.Button
    Friend WithEvents AddOneCardButton As System.Windows.Forms.Button
    Friend WithEvents Add20CardsButton As System.Windows.Forms.Button
    Friend WithEvents DisplayTotalsButton As System.Windows.Forms.Button
    Friend WithEvents FindaCardButton As System.Windows.Forms.Button
    Friend WithEvents DealaCardButton As System.Windows.Forms.Button
    Friend WithEvents DealaCardtoeachPlayerButton As System.Windows.Forms.Button
    Friend WithEvents RemoveaCardButton As System.Windows.Forms.Button
    Friend WithEvents RemoveaCardfromeachPlayerButton As System.Windows.Forms.Button
    Friend WithEvents CardDealerLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerDetailsLabel As System.Windows.Forms.Label
    Friend WithEvents PlayerDetailsInformationLabel As System.Windows.Forms.Label
    Friend WithEvents DeckofCardsLabel As System.Windows.Forms.Label
    Friend WithEvents DeckofCardsInformationLabel As System.Windows.Forms.Label
    Friend WithEvents SwapCardsButton As System.Windows.Forms.Button
    Friend WithEvents CreateAutoDeckButton As System.Windows.Forms.Button
    Friend WithEvents ShuffleCardsButton As System.Windows.Forms.Button
    Friend WithEvents DisplayCardorPlayerHistory As System.Windows.Forms.Button

End Class
