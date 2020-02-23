using System;
using System.IO;

namespace fileIOPjt
{
    class FileIOEx
    {
        static void Main(string[] args)
        {

            FileReaderWriter fileReaderWriter = new FileReaderWriter();
            /*
             * 파일 생성 및 열기
             */
            fileReaderWriter.CreateFile();
            fileReaderWriter.OpenFile();
            fileReaderWriter.OpenOrCreateFile();
            fileReaderWriter.TruncateFile();
            fileReaderWriter.AppendFile();
            fileReaderWriter.CreateNewFile();

            // 파일 쓰기(Write)
            fileReaderWriter.WriteData();

            // 파일 읽기(Read)
            fileReaderWriter.ReadData();

            Console.WriteLine();

            /*
             * 이진 데이터 처리 클래스 BianryWriter, BinaryReader
             */
            // 데이터 쓰기
            fileReaderWriter.DoBinaryWriter();

            // 데이터 읽기
            fileReaderWriter.DoBinaryReader();

            Console.WriteLine();

            /*
             * 텍스트 데이터 처리 클래스 StreamWriter, StreamReader
             */
            // 데이터 쓰기
            fileReaderWriter.DoStreamWriter();

            // 데이터 읽기
            fileReaderWriter.DoStreamReader();

            /*
             * 로그 파일 생성
             */
            // 디렉토리 생성
            string dirPath = "C:\\CSharp\\pjt\\lec21\\temp";
            if (Directory.Exists(dirPath))
            {
                Console.WriteLine("There is a temp directory.");
            }
            else
            {
                Console.WriteLine("There is no temp directory.");
                Directory.CreateDirectory(dirPath);
            }

            // 로그 기록
            string strTime = System.DateTime.Now.ToString("yyyy-MM-dd, hh:mm:ss");
            string strlog = "Something log.";

            FileStream fileStream = new FileStream(dirPath + "\\log.txt", FileMode.Append);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.WriteLine(strTime + " - "+ strlog);
            streamWriter.Close();
            fileStream.Close();

        }
    }
}
