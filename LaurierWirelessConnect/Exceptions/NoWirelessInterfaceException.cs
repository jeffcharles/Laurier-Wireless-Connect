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

using System;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace OpenSourceAtLaurier.LaurierWirelessConnect
{
    [Serializable]
    public class NoWirelessInterfaceException : Exception
    {

        public NoWirelessInterfaceException()
            : base()
        {
        }

        public NoWirelessInterfaceException(string message)
            : base(message)
        {
        }

        public NoWirelessInterfaceException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected NoWirelessInterfaceException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {

        }

        [SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
        }
    }
}
