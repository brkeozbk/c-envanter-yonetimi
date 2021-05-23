using System;
using System.Runtime.Serialization;

namespace MySql
{
    internal class Data
    {
        internal class MySqlClient
        {
            internal class MySqlConnection
            {
                public string ConnectionString { get; internal set; }

                internal void Open()
                {
                    throw new NotImplementedException();
                }
            }

            [Serializable]
            internal class MySqlException : Exception
            {
                public MySqlException()
                {
                }

                public MySqlException(string message) : base(message)
                {
                }

                public MySqlException(string message, Exception innerException) : base(message, innerException)
                {
                }

                protected MySqlException(SerializationInfo info, StreamingContext context) : base(info, context)
                {
                }
            }
        }
    }
}