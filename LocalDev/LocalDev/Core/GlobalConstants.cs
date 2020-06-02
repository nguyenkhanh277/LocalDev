﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows.Forms;

namespace LocalDev.Core
{
    public class GlobalConstants
    {
        #region Default Values
        public static string Username = "";
        public static string FullName = "";
        public static int Language = 0;
        public static int DEFAULT_SALT_LENGTH = 5;
        public static bool DEBUG_MODE = true;
        public enum SearchConditions { }
        public enum GenderValue { Female, Male }
        public enum StatusValue { NoUse, Using }
        public enum LanguageValue { Vietnamese, English }
        #endregion

        public static bool IsNumericType(Type type)
        {
            HashSet<Type> NumericTypes = new HashSet<Type>
            {
                typeof(decimal), typeof(byte), typeof(sbyte),
                typeof(short), typeof(ushort), typeof(float)
            };
            return NumericTypes.Contains(type) || NumericTypes.Contains(Nullable.GetUnderlyingType(type));
        }

        public static void ExportExcel(DevExpress.XtraGrid.GridControl gridControl)
        {
            try
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Excel|*.xls;*.xlsx";
                saveFileDialog1.RestoreDirectory = true;

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    gridControl.ExportToXlsx(saveFileDialog1.FileName);
                    // Open the created XLSX file with the default application. 
                    try
                    {
                        Process.Start(saveFileDialog1.FileName);
                    }
                    catch { }
                }
            }
            catch { }

        }
    }
}
