using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.Core.Services
{
    public interface IHashService
    {
        string GetHash(string value);
    }
}
