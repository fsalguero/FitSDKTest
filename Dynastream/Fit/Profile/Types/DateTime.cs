#region Copyright
////////////////////////////////////////////////////////////////////////////////
// The following FIT Protocol software provided may be used with FIT protocol
// devices only and remains the copyrighted property of Dynastream Innovations Inc.
// The software is being provided on an "as-is" basis and as an accommodation,
// and therefore all warranties, representations, or guarantees of any kind
// (whether express, implied or statutory) including, without limitation,
// warranties of merchantability, non-infringement, or fitness for a particular
// purpose, are specifically disclaimed.
//
// Copyright 2014 Dynastream Innovations Inc.
////////////////////////////////////////////////////////////////////////////////
// ****WARNING****  This file is auto-generated!  Do NOT edit this file.
// Profile Version = 11.0Release
// Tag = $Name: AKW11_000 $
////////////////////////////////////////////////////////////////////////////////

#endregion

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.IO;

namespace Dynastream.Fit
{
   /// <summary>
      /// The DateTime class implements the Fit date_time type which references 
      /// UTC 00:00 Dec 31 1989 in second resolution
      /// </summary>  
   public class DateTime
   {
      #region Fields    
      private uint timeStamp; 
      // if date_time is < 0x10000000 then it is system time (seconds from device power on) 
      // 0x10000000 => uptime of 8years => earliest date you can express ~1997    
      private uint min = 0x10000000;
      // .NET datetime uses 100ns ticks starting 12:00:00 midnight, January 1, 0001       
      public System.DateTime offset = new System.DateTime(1989, 12, 31, 0, 0, 0, System.DateTimeKind.Utc);
      #endregion // Fields

       #region Properties

      #endregion // Properties
      
      #region Constructors
      public DateTime (uint timeStamp)
      {
         this.timeStamp = timeStamp;
      }

      public DateTime(System.DateTime dateTime)
      {
         timeStamp = (uint)((dateTime.Ticks - offset.Ticks) / 10000000);
      }
      #endregion // Constructors

      #region Methods
      public bool Equals(DateTime dateTime)
      {
         return (this.timeStamp == dateTime.GetTimeStamp());
      }

      public uint GetTimeStamp()
      {
         return timeStamp;
      }

      public void ConvertSystemTimeToUTC(uint systemTimeOffset)
      {
         if (timeStamp < min) 
         {
            timeStamp += systemTimeOffset;
         }
      }

      public System.DateTime GetDateTime()
      {       
         return new System.DateTime(timeStamp * 10000000L + offset.Ticks);
      }

      new public string ToString()
      {
         return GetDateTime().ToString();
      }
      #endregion // Methods
   } // class
} // namespace
