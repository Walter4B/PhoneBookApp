using System;
using System.Data;
using ConsoleTableExt;
using System.Configuration;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace PhoneBookApp
{
    class Program
    {
        public static void Main()
        {
            UserController userController = new UserController();

            userController.UserControlls();
        }
    }
}