CREATE TABLE funcionarios(
Id int NOT NULL AUTO_INCREMENT,
Nome VARCHAR(250) NOT NULL,
Data_Nascimento DATETIME NOT NULL,
Sexo BOOL NOT NULL,
Cpf VARCHAR(16) NOT NULL,
Nacionalidade VARCHAR(250) NOT NULL,
Naturalidade VARCHAR(250) NOT NULL,
Email VARCHAR(250) NOT NULL,
Telefone VARCHAR(16) NOT NULL,
Telefone_Contato VARCHAR(16) NOT NULL,
Cep VARCHAR(12) NOT NULL,
logradouro VARCHAR(250) NOT NULL,
Numero VARCHAR(5) NOT NULL,
Complemento VARCHAR(250) NOT NULL,
Bairro VARCHAR(250) NOT NULL,
Municipio VARCHAR(250) NOT NULL,
Uf VARCHAR(2) NOT NULL,
CONSTRAINT pk_usuarios_id PRIMARY KEY(Id)
);
