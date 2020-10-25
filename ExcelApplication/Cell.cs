﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExcelApplication
{
    public class Cell : DataGridViewTextBoxCell
    {
        public string Name { get; set; }
        public new string Value { get; set; }
        public string Expression { get; set; }

        public int Row { get; set; }
        public int Column { get; set; }

        public List<Cell> CellsDependentOnThis = new List<Cell>();
        public List<Cell> ThisCellDependsOn = new List<Cell>();
        public List<Cell> NewThisCellDepOn = new List<Cell>();

        public Cell(int row, int column)
        {
            this.Row = row;
            this.Column = column;
            Value = "0";
            Expression = "";
            Name = NumberConverter.ConvertTo26System(column) + Convert.ToString(row);
        }

        public void SetCell(string value, string expression, List<Cell> depOnCell, List<Cell> cellDepOn)
        {
            this.Value = value;
            this.Expression = expression;
            this.ThisCellDependsOn.Clear();
            this.ThisCellDependsOn.AddRange(cellDepOn);

            this.CellsDependentOnThis.Clear();
            this.CellsDependentOnThis.AddRange(depOnCell);
        }

        public bool ContainsLoop(List<Cell> cells)
        {
            foreach(var cell in cells)
            {
                if(cell.Name == Name)
                {
                    return true;
                }
            }
            foreach(var depOnCell in CellsDependentOnThis)
            {
                foreach(var cell in cells)
                {
                    if(depOnCell.Name == cell.Name)
                    {
                        return true;
                    }
                }
                if(depOnCell.ContainsLoop(cells))
                {
                    return true;
                }
            }
            return false;
        }

        public void AddCellDepOnAndDepOnCell()
        {
            foreach(Cell cellDepOn in NewThisCellDepOn)
            {
                cellDepOn.CellsDependentOnThis.Add(this);
            }
            ThisCellDependsOn = NewThisCellDepOn;
        }

        public void RemoveCellDepOnAndDepOnCell()
        {
            if(ThisCellDependsOn != null)
            {
                foreach(Cell cellDepOn in ThisCellDependsOn)
                {
                    cellDepOn.CellsDependentOnThis.Remove(this);
                }
                ThisCellDependsOn = null;
            }
            return;
        }



       
    }
}
