using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Packet
    {
        private byte _dest, _src, _size, _crc;
        byte[] _data;
        const byte _SOH = 1;

        public byte Dest { get => _dest; set => _dest = value; }
        public byte Src { get => _src; set => _src = value; }
        public byte Size { get => _size; set => _size = value; }
        public byte Crc { get => _crc; set => _crc = value; }

        public void packet()
        {

        }

        public void packet(byte[] input)
        {
            if (input.Length< 5)
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
            temp[0] = _SOH;
            temp[1] = _dest;
            temp[2] = _src;
            temp[3] = _size;
            for(byte i = 0; i < _data.Length; i++)
            {
                temp[4 + i] = _data[i];
            }



            temp[temp.Length - 1] = _crc;

            return temp;
        }

    }
}
