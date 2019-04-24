using System;

namespace CRCLibrary
{
    public class CRCGenerator
    {
        string data;
        string crcBinary;
        int crcbits;
        public CRCGenerator(string Data, string CRCBinary, int CRCbits)
        {
            data = Data;
            crcBinary = CRCBinary;
            crcbits = CRCbits;
        }
        private int StringBinaryToint(string InputData)
        {
            if (InputData == "") return 0;
            int Value = 0;
            int ReturnValue = 0;
            for (int i = 0; i < InputData.Length; i++)
            {
                try
                {
                    Value = int.Parse(InputData[i].ToString());
                    if (Value == 1)
                        ReturnValue += (int)Math.Pow(2, InputData.Length - 1 - i);
                    else if (Value > 1)
                        throw new Exception("Invalid!");
                }
                catch
                {
                    throw new Exception("Invalid!");
                }
            }
            return ReturnValue;
        }
        public int GetCRC()
        {
            int CurrentByte = 0;
            int NumberOfBytes = data.Length - 1;
            int SubRegister = 0;
            int CRCValue = StringBinaryToint(crcBinary);
            for (int CurrentBit = 7; CurrentBit >= -1; CurrentBit--) //this reads backwards through a byte.
            {
                if (CurrentBit == -1)
                {
                    if (CurrentByte == NumberOfBytes)
                    {
                        for (int x = 0; x < 8; x++)
                        {
                            if (SubRegister >= Math.Pow(2, crcbits))// this means theres a 1 in the left most bit.
                            {
                                SubRegister ^= CRCValue;
                            }
                            if ((data[CurrentByte] & (1 << CurrentBit)) != 0) //if bit is set.
                            {
                                SubRegister = (SubRegister * 2) + 1;
                            }
                            else
                            {
                                SubRegister = (SubRegister * 2);
                            }
                        }
                        if (SubRegister >= Math.Pow(2, crcbits))// this means theres a 1 in the left most bit.
                        {
                            SubRegister ^= CRCValue;
                        }
                        break;
                    }
                    else
                    {
                        CurrentByte++;
                        CurrentBit = 8;
                    }
                }
                else
                {
                    if (SubRegister >= Math.Pow(2, crcbits))// this means theres a 1 in the left most bit.
                    {
                        SubRegister ^= CRCValue;
                    }
                    if ((data[CurrentByte] & (1 << CurrentBit)) != 0) //if bit is set.
                    {
                        SubRegister = (SubRegister * 2) + 1;
                    }
                    else
                    {
                        SubRegister = (SubRegister * 2);
                    }
                }
            }
            return SubRegister;
        }
    }
}
