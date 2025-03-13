using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibMatrix
{

    public class Matrix
    {
        private List<List<int>> data = new List<List<int>>();
        private int value;

        public Matrix (int cols)
        {
            value = cols;
        }

        public void AddRow(List <int> row)
        {
            data.Add(row);
        }

        public override bool Equals(object obj)
        {
            if (obj is Matrix other)
            {
                if (data.Count != other.data.Count)
                {
                    return false;
                }

                for (int i = 0; i < data.Count; i++)
                {
                    List<int> currentlist = data[i];
                    List<int> otherlist = other.data[i];
                    if (currentlist.Count != otherlist.Count)
                    {
                        return false;
                    }

                    for (int j = 0; j < currentlist.Count; j++)
                    {
                        if (currentlist[j] != otherlist[j])
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
    
}
