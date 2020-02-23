using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace fileIOPjt
{
    class FileReaderWriter
    {

        public FileReaderWriter()
        {
            Console.WriteLine("=== FileReaderWriter DEFAULT CONSTRUCTOR ===");
        }

        // 새 파일 생성
        public void CreateFile()
        {
            Stream stream = new FileStream("new_file.dat", FileMode.Create);
            stream.Close();
        }

        // 파일 열기
        public void OpenFile()
        {
            Stream stream = new FileStream("new_file.dat", FileMode.Open);
            stream.Close();
        }

        // 파일을 열기. 파일이 없으면 생성
        public void OpenOrCreateFile()
        {
            Stream stream = new FileStream("new_file.dat", FileMode.OpenOrCreate);
            stream.Close();
        }

        // 파일을 비워서 열기
        public void TruncateFile()
        {
            Stream stream = new FileStream("new_file.dat", FileMode.Truncate);
            stream.Close();
        }

        // 데이터 추가 모드로 파일 열기
        public void AppendFile()
        {
            Stream stream = new FileStream("new_file.dat", FileMode.Append);
            stream.Close();
        }

        // 파일 생성. 동일한 이름의 파일이 있으면 예외(System.IO.IOException) 발생
        public void CreateNewFile()
        {
            Stream stream = null;

            try
            {
                stream = new FileStream("new_file.dat", FileMode.CreateNew);
            }
            catch (IOException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                if(stream != null) stream.Close();
            }
            
        }

        public void WriteData()
        {
            int value = 123456;
            Stream stream = new FileStream("new_file.dat", FileMode.Create);
            byte[] wBytes = BitConverter.GetBytes(value);
            stream.Write(wBytes, 0, wBytes.Length);
            stream.Close();
        }

        public void ReadData()
        {
            byte[] rBytes = new byte[8];
            Stream stream = new FileStream("new_file.dat", FileMode.Open);
            stream.Read(rBytes, 0, rBytes.Length);
            int value = BitConverter.ToInt32(rBytes, 0);
            stream.Close();

            Console.WriteLine($"value : {value}");
        }

        public void DoBinaryWriter()
        {
            FileStream fileStream = new FileStream("binary_data_file.dat", FileMode.Create);
            BinaryWriter binaryWriter = new BinaryWriter(fileStream);
            binaryWriter.Write("Hello C#");
            binaryWriter.Write("안녕하세요.");
            binaryWriter.Write('A');
            binaryWriter.Write(12345);
            binaryWriter.Close();
        }

        public void DoBinaryReader()
        {
            FileStream fileStream = new FileStream("binary_data_file.dat", FileMode.Open);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            Console.WriteLine($"binaryReader.ReadString() : {binaryReader.ReadString()}");
            Console.WriteLine($"binaryReader.ReadString() : {binaryReader.ReadString()}");
            Console.WriteLine($"binaryReader.ReadChar() : {binaryReader.ReadChar()}");
            Console.WriteLine($"binaryReader.ReadInt32() : {binaryReader.ReadInt32()}");
            binaryReader.Close();
        }

        public void DoStreamWriter()
        {
            FileStream fileStream = new FileStream("text_data_file.dat", FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(fileStream);
            streamWriter.Write("Hello");
            streamWriter.Write(" ");
            streamWriter.WriteLine("C#");
            streamWriter.Write("안녕하세요.\n");
            streamWriter.WriteLine("C#입니다.");
            streamWriter.WriteLine(12345);
            streamWriter.Close();
        }

        public void DoStreamReader()
        {
            FileStream fileStream = new FileStream("text_data_file.dat", FileMode.Open);
            StreamReader streamReader = new StreamReader(fileStream);

            while(streamReader.EndOfStream == false)
            {
                Console.WriteLine(streamReader.ReadLine());
            }
            streamReader.Close();
        }

    }
}
