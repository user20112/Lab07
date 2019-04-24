using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CRCLibrary;

namespace Lab07_Client
{
    class Packet
    {
        private byte _dest, _src, _size, _crc, _soh;
        byte[] _data;
        

        public byte Dest { get => _dest; set => _dest = value; }
        public byte Src { get => _src; set => _src = value; }
        public byte Size { get => _size; set => _size = value; }
        public byte Crc { get => _crc; set => _crc = value; }
        public byte Dest1 { get => _dest; set => _dest = value; }

        public void packet(char soh, char dest, char src, string text)
        {
            _soh = (byte)soh;
            _dest = (byte)dest;
            _src = (byte)src; 

            _data = new byte[text.Length];
            for(int i = 0; i < text.Length; i++)
            {
                _data[i] = (byte)text[i];
            }
            _size = (byte)_data.Length;

            CRCGenerator crc = new CRCGenerator((char)_soh + (char)_dest + (char)_src + (char)_size + _data.ToString(), "100100101", 8);
            _crc = (byte)crc.GetCRC();

        }

        public void packet(byte[] input)
        {
            if (input.Length < 5)
            {
                return;
            }

            _dest = input[1];
            _src = input[2];
            _size = input[3];
            _data = input.ToList().GetRange(4, _size).ToArray();
            _crc = input.Last();
        }

        public byte[] getPacket()
        {
            byte[] temp = new byte[5 + _size];
            temp[0] = _soh;
            temp[1] = _dest;
            temp[2] = _src;
            temp[3] = _size;
            for (byte i = 0; i < _data.Length; i++)
            {
                temp[4 + i] = _data[i];
            }



            temp[temp.Length - 1] = _crc;

            return temp;
        }

        public string getData()
        {
            string temp = "";
            foreach(byte x in _data)
            {
                temp += (char)x;
            }
            return temp;
        }
    }
}
