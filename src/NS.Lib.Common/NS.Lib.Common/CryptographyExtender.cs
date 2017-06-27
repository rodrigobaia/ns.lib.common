using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace NS.Lib.Common
{
    //#region [ Enums ]

    ///// <summary>
    ///// Enumerator com os tipos de classes para criptografia.
    ///// </summary>
    //public enum CryptProvider
    //{
    //    None = 0,

    //    /// <summary>
    //    /// Representa a classe base para implementações criptografia dos algoritmos simétricos Rijndael.
    //    /// </summary>
    //    Rijndael,
    //    /// <summary>
    //    /// Representa a classe base para implementações do algoritmo RC2.
    //    /// </summary>
    //    RC2,
    //    /// <summary>
    //    /// Representa a classe base para criptografia de dados padrões (DES - Data Encryption Standard).
    //    /// </summary>
    //    DES,
    //    /// <summary>
    //    /// Representa a classe base (TripleDES - Triple Data Encryption Standard).
    //    /// </summary>
    //    TripleDES,
    //    /// <summary>
    //    /// Representa a base64 de Criptografia
    //    /// </summary>
    //    Base64,
    //}

    //#endregion [ Enums ]

    ///// <summary>
    ///// Criptografia de texto
    ///// </summary>
    //public static class CryptographyExtender
    //{
    //    #region Variáveis e Métodos Privados

    //    private static string _key = string.Empty;
    //    private static CryptProvider _cryptProvider = CryptProvider.None;
    //    private static SymmetricAlgorithm _algorithm;

    //    private static void Constructor()
    //    {
    //        if (_algorithm == null)
    //        {
    //            _algorithm = new RijndaelManaged();
    //            _algorithm.Mode = CipherMode.CBC;
    //        }

    //        if (_cryptProvider == CryptProvider.None) _cryptProvider = CryptProvider.Rijndael;
    //    }

    //    /// <summary>
    //    /// Inicialização do vetor do algoritmo simétrico
    //    /// </summary>
    //    private static void SetIV()
    //    {
    //        Constructor();

    //        switch (_cryptProvider)
    //        {
    //            case CryptProvider.Rijndael:
    //                _algorithm.IV = new byte[] { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9, 0x5, 0x46, 0x9c, 0xea, 0xa8, 0x4b, 0x73, 0xcc };
    //                break;
    //            default:
    //                _algorithm.IV = new byte[] { 0xf, 0x6f, 0x13, 0x2e, 0x35, 0xc2, 0xcd, 0xf9 };
    //                break;
    //        }
    //    }

    //    #endregion

    //    #region Public methods

    //    /// <summary>
    //    /// Encripta o dado solicitado.
    //    /// </summary>
    //    /// <param name="texto">Texto a ser criptografado.</param>
    //    /// <returns>Texto criptografado.</returns>
    //    public static string Encrypt(this string texto)
    //    {
    //        return EncryptImpl(texto);
    //    }

    //    /// <summary>
    //    /// Desencripta o dado solicitado.
    //    /// </summary>
    //    /// <param name="textoCriptografado">Texto a ser descriptografado.</param>
    //    /// <returns>Texto descriptografado.</returns>
    //    public static string Decrypt(this string textoCriptografado)
    //    {
    //        return DecryptImpl(textoCriptografado);
    //    }

    //    /// <summary>
    //    /// Segurança Hash MD5
    //    /// </summary>
    //    /// <param name="input">valor a ser criptografado</param>
    //    /// <returns>valor criptografado</returns>
    //    public static string EncryptHash(this string input)
    //    {
    //        return getMD5Hash(input).ToLower();
    //    }

    //    #endregion

    //    #region [ Metodos Privados ]

    //    private static string EncryptImpl(this string texto)
    //    {
    //        Constructor();
    //        byte[] plainByte = Encoding.UTF8.GetBytes(texto);
    //        byte[] keyByte = GetKey();

    //        // Seta a chave privada
    //        _algorithm.Key = keyByte;
    //        SetIV();

    //        // Interface de criptografia / Cria objeto de criptografia
    //        ICryptoTransform cryptoTransform = _algorithm.CreateEncryptor();

    //        MemoryStream _memoryStream = new MemoryStream();

    //        CryptoStream _cryptoStream = new CryptoStream(_memoryStream, cryptoTransform, CryptoStreamMode.Write);

    //        // Grava os dados criptografados no MemoryStream
    //        _cryptoStream.Write(plainByte, 0, plainByte.Length);
    //        _cryptoStream.FlushFinalBlock();

    //        // Busca o tamanho dos bytes encriptados
    //        byte[] cryptoByte = _memoryStream.ToArray();

    //        // Converte para a base 64 string para uso posterior em um xml
    //        return Convert.ToBase64String(cryptoByte, 0, cryptoByte.GetLength(0));
    //    }

    //    private static string DecryptImpl(this string textoCriptografado)
    //    {
    //        Constructor();
    //        // Converte a base 64 string em num array de bytes
    //        byte[] cryptoByte = Convert.FromBase64String(textoCriptografado);
    //        byte[] keyByte = GetKey();

    //        // Seta a chave privada
    //        _algorithm.Key = keyByte;
    //        SetIV();

    //        // Interface de criptografia / Cria objeto de descriptografia
    //        ICryptoTransform cryptoTransform = _algorithm.CreateDecryptor();
    //        try
    //        {
    //            MemoryStream _memoryStream = new MemoryStream(cryptoByte, 0, cryptoByte.Length);

    //            CryptoStream _cryptoStream = new CryptoStream(_memoryStream, cryptoTransform, CryptoStreamMode.Read);

    //            // Busca resultado do CryptoStream
    //            StreamReader _streamReader = new StreamReader(_cryptoStream);
    //            return _streamReader.ReadToEnd();
    //        }
    //        catch
    //        {
    //            return null;
    //        }
    //    }

    //    /// <summary>
    //    /// Gera a chave de criptografia válida dentro do array.
    //    /// </summary>
    //    /// <returns>Chave com array de bytes.</returns>
    //    private static byte[] GetKey()
    //    {
    //        Constructor();
    //        string salt = string.Empty;

    //        // Ajusta o tamanho da chave se necessário e retorna uma chave válida
    //        if (_algorithm.LegalKeySizes.Length > 0)
    //        {
    //            // Tamanho das chaves em bits
    //            int keySize = _key.Length * 8;
    //            int minSize = _algorithm.LegalKeySizes[0].MinSize;
    //            int maxSize = _algorithm.LegalKeySizes[0].MaxSize;
    //            int skipSize = _algorithm.LegalKeySizes[0].SkipSize;

    //            if (keySize > maxSize)
    //            {
    //                // Busca o valor máximo da chave
    //                _key = _key.Substring(0, maxSize / 8);
    //            }
    //            else if (keySize < maxSize)
    //            {
    //                // Seta um tamanho válido
    //                int validSize = (keySize <= minSize) ? minSize : (keySize - keySize % skipSize) + skipSize;
    //                if (keySize < validSize)
    //                {
    //                    // Preenche a chave com arterisco para corrigir o tamanho
    //                    _key = _key.PadRight(validSize / 8, '*');
    //                }
    //            }
    //        }
    //        PasswordDeriveBytes key = new PasswordDeriveBytes(_key, ASCIIEncoding.ASCII.GetBytes(salt));
    //        return key.GetBytes(_key.Length);
    //    }

    //    /// <summary>
    //    /// Criptografia hash md5
    //    /// </summary>
    //    /// <param name="input"></param>
    //    /// <returns></returns>
    //    private static string getMD5Hash(this string input)
    //    {
    //        System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
    //        byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
    //        byte[] hash = md5.ComputeHash(inputBytes);
    //        System.Text.StringBuilder sb = new System.Text.StringBuilder();
    //        for (int i = 0; i < hash.Length; i++)
    //        {
    //            sb.Append(hash[i].ToString("X2"));
    //        }
    //        return sb.ToString();
    //    }
    //    #endregion [ Metodos Privados ]
    //}
}
