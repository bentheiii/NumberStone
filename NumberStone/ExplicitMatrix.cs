﻿using System;
using WhetStone.Looping;
using WhetStone.SystemExtensions;

namespace NumberStone
{
    public class ExplicitMatrix<T> : Matrix<T>
    {
        private readonly T[,] _values;
        public ExplicitMatrix(T[,] values)
        {
            _values = values.Copy();
        }
        public ExplicitMatrix(int rows, int collumns, Func<int, int, T> filler)
        {
            this._values = fill2D.Fill2D(rows, collumns, filler);
        }
        public override T this[int i, int j]
        {
            get
            {
                return this._values[i, j];
            }
        }
        public override int rows
        {
            get
            {
                return this._values.GetLength(0);
            }
        }
        public override int collumns
        {
            get
            {
                return this._values.GetLength(1);
            }
        }
    }
}
