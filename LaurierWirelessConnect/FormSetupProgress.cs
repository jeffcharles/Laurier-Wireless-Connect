#region Copyright
// <copyright file="LICENSE.txt" company="Open Source at Laurier">
//
// Copyright (C) 2010 Open Source at Laurier
//
// This file is part of the Laurier Wireless Connect application.
//
// The Laurier Wireless Connect application is free software: you can
// redistribute it and/or modify it under the terms of the GNU General 
// Public License as published by the Free Software Foundation, either 
// version 3 of the License, or (at your option) any later version.
//
// The Laurier Wireless Connect application is distributed in the 
// hope that it will be useful, but WITHOUT ANY WARRANTY; without 
// even the implied warranty of MERCHANTABILITY or FITNESS FOR A 
// PARTICULAR PURPOSE.  See the GNU General Public License for more 
// details.
//
// You should have received a copy of the GNU General Public License
// along with the Laurier Wireless Connect application.  If not,
// see <http://www.gnu.org/licenses/>.
// </copyright>
#endregion

using System.Windows.Forms;

namespace OpenSourceAtLaurier.LaurierWirelessConnect
{
    public partial class FormSetupProgress : Form
    {
        public FormSetupProgress()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Update the value in the label describing the command being executed
        /// </summary>
        /// <param name="commandDescription">A string describing the command being executed</param>
        public void UpdateCurrentCommandDescriptionLabel(string commandDescription)
        {
            labelCurrentCommandDescription.Text = commandDescription;
        }

        /// <summary>
        /// Update the position of the setup progress bar
        /// </summary>
        /// <param name="value">An integer between 0 and 3, with 0 being the left and 3 being the right</param>
        public void UpdateSetupProgressBarValue(int value)
        {
            progressBarSetup.Value = value;
        }
    }
}
