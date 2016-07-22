using System;
using System.Numerics;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        public static Keys RSAGetKeys()
        {
            //Generate 2 big (preferably 100+digit) prime numbers p and q
            //n = p * q
            // Multiply the numbers and store them in n - modulus
            //Calculate totient using the following formular
            //phi(n) = (p-1)*(q-1)

            //var e = GetPublicKey(totient);
            //var d = GetPrivateKey(totient, e);
            //return keys
            throw new NotImplementedException();
        }
        public static BigInteger GetPublicKey(BigInteger totient)
        {
            //Generate 50digit prime that is coprime with totient
            //Hint use GetBigPrime to generate the number
            //Hint use Euclidean Algorithm to test if numbers are coprime
            throw new NotImplementedException();

        }
        public static BigInteger GetPrivateKey(BigInteger totient, BigInteger e)
        {
            //Use Modular Multiplicative Inverse to generate the private key
            //Pass totient and e to the method
            //If the resulting inverse is negative return the sum of the inverse and the totient
            throw new NotImplementedException();

        }
        public static BigInteger RSAEncrypt(BigInteger public_key, BigInteger n, BigInteger message)
        {
            //Use the ModPow to return the remainer of the (m)^public_key % n
            throw new NotImplementedException();

        }
        public static BigInteger RSADecrypt(BigInteger private_key, BigInteger n, BigInteger message)
        {
            //Use the ModPow to return the remainer of the (m)^private_key % n
            throw new NotImplementedException();

        }
    }

    public class Keys
    {
        private BigInteger public_key;
        private BigInteger private_key;
        private BigInteger modulus;

        public Keys(BigInteger pub_key, BigInteger priv_key, BigInteger mod)
        {
            public_key = pub_key;
            private_key = priv_key;
            modulus = mod;
        }

        public BigInteger GetPublicKey()
        {
            return public_key;
        }
        public BigInteger GetPrivateKey()
        {
            return private_key;
        }
        public BigInteger GetModulus()
        {
            return modulus;
        }
    }
}
