CREATE TABLE tbl_message 
(
Id INT IDENTITY(1,1) PRIMARY KEY,
 EncryptedMessage VARCHAR(200),
 DecryptedMessage VARCHAR(200),
 PrivateKey VARCHAR(200),
 PublicKey VARCHAR(200),
 Modulus VARCHAR(200),
);