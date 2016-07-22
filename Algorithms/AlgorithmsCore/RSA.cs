using System;
using System.Numerics;

namespace AlgorithmsCore
{
    public static partial class Algorithms
    {
        //private static readonly BigInteger p = BigInteger.Parse("12131072439211271897323671531612440428472427633701410925634549312301964373042085619324197365322416866541017057361365214171711713797974299334871062829803541");
        //private static readonly BigInteger q = BigInteger.Parse("12027524255478748885956220793734512128733387803682075433653899983955179850988797899869146900809131611153346817050832096022160146366346391812470987105415233");
        //private static readonly BigInteger e = 65537;
        //private static readonly BigInteger d = BigInteger.Parse("89489425009274444368228545921773093919669586065884257445497854456487674839629818390934941973262879616797970608917283679875499331574161113854088813275488110588247193077582527278437906504015680623423550067240042466665654232383502922215493623289472138866445818789127946123407807725702626644091036502372545139713");

        public static Keys RSAGetKeys()
        {
            //Generate 2 big (preferably 100+digit) prime numbers p and q
            var p = GetBigPrime(100);
            var q = GetBigPrime(100);
            //n = p * q
            // Multiply the numbers and store them in n - modulus
            var n = BigInteger.Multiply(p, q);
            //Calculate totient using the following formular
            //phi(n) = (p-1)*(q-1)
            var totient = BigInteger.Multiply((p - 1), (q - 1));

            var e = GetPublicKey(totient);
            var d = GetPrivateKey(totient, e);
            //return keys
            return new Keys(e, d, n);
        }
        public static BigInteger GetPublicKey(BigInteger totient)
        {
            //Generate 50digit prime that is coprime with totient
            //Hint use GetBigPrime to generate the number
            //Hint use Euclidean Algorithm to test if numbers are coprime
            var length = (50);
            BigInteger e = 5;
            do
            {
                e = GetBigPrime(length);
                if (EuclideanAlgorithm(e, totient) == 1)
                    return e;
            } while (true);
        }
        public static BigInteger GetPrivateKey(BigInteger totient, BigInteger e)
        {
            //Use Modular Multiplicative Inverse to generate the private key
            //Pass totient and e to the method
            //If the resulting inverse is negative return the sum of the inverse and the totient
            BigInteger[] d = new BigInteger[3];
            d = ExtendedEuclideanAlgorithm(totient, e);
            if (d[2] < 0)
                d[2] = d[2] + totient;
            return d[2];
        }
        public static BigInteger RSAEncrypt(BigInteger public_key, BigInteger n, BigInteger message)
        {
            //Use the ModPow to return the remainer of the (m)^public_key % n
            return BigInteger.ModPow(message, public_key, n);
        }
        public static BigInteger RSADecrypt(BigInteger private_key, BigInteger n, BigInteger message)
        {
            //Use the ModPow to return the remainer of the (m)^private_key % n
            return BigInteger.ModPow(message, private_key, n);
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
