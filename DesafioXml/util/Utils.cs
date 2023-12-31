﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioXml.util
{
    class Utils
    {
        public Utils()
        {
        }
        public static string PathVerification()
        {
            string path;
            while (true)
            {
                Console.WriteLine("Insira o caminho da pasta pgm do Playlist: \n");
                path = Console.ReadLine();
                path += @"\Montagem";
                if (!Directory.Exists(path))
                {
                    Console.Clear();
                    Console.WriteLine("Insira um caminho válido!");
                    continue;
                }
                break;
            }
            return path;
        }
        public static DateTime DataVerification()
        {
            string inputDate;
            while (true)
            {
                Console.WriteLine("Escolha a data do montagem que você deseja visualizar:\nExemplo: dd-mm-yyyy ");
                inputDate = Console.ReadLine();
                if (!DateTime.TryParseExact(inputDate, "dd-MM-yyyy", null, System.Globalization.DateTimeStyles.AssumeLocal, out DateTime data))
                {
                    
                    Console.Clear();
                    Console.WriteLine("Formato de data inválido.");
                    continue;
                }
                return data;
            }
            
        }

        public static DateTime TimeVerification()
        {
            string inputTime;
            while (true)
            {
                Console.WriteLine("Escolha a hora do bloco que você visualizar:\nExemplo: 20:30");
                inputTime = Console.ReadLine();
                if (!DateTime.TryParseExact(inputTime, "HH:mm", null, System.Globalization.DateTimeStyles.None, out DateTime time))
                {
                    Console.Clear();
                    Console.WriteLine("Formato inválido.");
                    continue;
                }

                return time;
            }
        }
        public static string OptionVerification()
        {
            string inputOption;
            do
            {
                Console.WriteLine("\nEscolha uma opção:\n1 - Imprimir a programação completa\n2 - Imprimir um bloco específico\n3 - Sair");
                inputOption = Console.ReadLine();
                if (inputOption != "1" & inputOption != "2" & inputOption != "3")
                {
                    Console.Clear();   
                    Console.WriteLine("Insira uma opção válida");
                    continue;
                }
                else if (inputOption == "1" || inputOption == "2")
                {
                    Console.Clear();   
                    return inputOption;
                }
                else
                {
                    System.Environment.Exit(1);
                }
            } while (true);
        }
    }
}
