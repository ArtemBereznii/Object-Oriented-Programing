using System;

namespace Lab3_4
{
    
    /// Клас-аргумент, що містить додаткову інформацію про подію
    public class OutOfGasEventArgs : EventArgs
    {
        /// Скільки палива не вистачило для завершення поїздки.
        public double FuelDeficit { get; }

        /// Час, коли сталася подія.
        public DateTime TimeOfEvent { get; }

        public OutOfGasEventArgs(double deficit, DateTime time)
        {
            FuelDeficit = deficit;
            TimeOfEvent = time;
        }
    }
}