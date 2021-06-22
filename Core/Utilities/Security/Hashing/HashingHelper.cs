using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Security.Hashing
{
    public class HashingHelper
    {
        public static void CreatePasswordHash(string password, out byte[] paswordHash, out byte[] paswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                paswordSalt = hmac.Key;
                paswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
            }


        }

        public static bool VerifyPasswordHash(string password,  byte[] paswordHash, byte[] paswordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(paswordSalt))
            {
             
              var  computedPaswordHash = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                for(int i = 0; i < computedPaswordHash.Length; i++)
                {
                    if (computedPaswordHash[i] != paswordHash[i])
                        return false;

                }
            }
            return true;
        }
    }
}