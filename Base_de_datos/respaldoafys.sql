-- MySQL dump 10.13  Distrib 8.0.29, for Win64 (x86_64)
--
-- Host: localhost    Database: proyecto
-- ------------------------------------------------------
-- Server version	5.5.5-10.4.24-MariaDB

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8mb4 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `administrador`
--

DROP TABLE IF EXISTS `administrador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `administrador` (
  `EmailAdministrador` varchar(30) NOT NULL,
  PRIMARY KEY (`EmailAdministrador`),
  CONSTRAINT `administrador_ibfk_1` FOREIGN KEY (`EmailAdministrador`) REFERENCES `usuario` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `administrador`
--

LOCK TABLES `administrador` WRITE;
/*!40000 ALTER TABLE `administrador` DISABLE KEYS */;
/*!40000 ALTER TABLE `administrador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arbitra`
--

DROP TABLE IF EXISTS `arbitra`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arbitra` (
  `IdPartido` int(11) NOT NULL AUTO_INCREMENT,
  `IdEncuentro` int(11) NOT NULL,
  `IdArbitro` int(11) NOT NULL,
  PRIMARY KEY (`IdPartido`,`IdEncuentro`,`IdArbitro`),
  KEY `IdEncuentro` (`IdEncuentro`),
  KEY `IdArbitro` (`IdArbitro`),
  CONSTRAINT `arbitra_ibfk_1` FOREIGN KEY (`IdPartido`) REFERENCES `partido` (`IdPartido`),
  CONSTRAINT `arbitra_ibfk_2` FOREIGN KEY (`IdEncuentro`) REFERENCES `encuentro` (`IdEncuentro`),
  CONSTRAINT `arbitra_ibfk_3` FOREIGN KEY (`IdArbitro`) REFERENCES `arbitro` (`IdArbitro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arbitra`
--

LOCK TABLES `arbitra` WRITE;
/*!40000 ALTER TABLE `arbitra` DISABLE KEYS */;
/*!40000 ALTER TABLE `arbitra` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `arbitro`
--

DROP TABLE IF EXISTS `arbitro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `arbitro` (
  `IdArbitro` int(11) NOT NULL AUTO_INCREMENT,
  `CantEncuentros` int(11) DEFAULT NULL,
  `Nombre` varchar(20) DEFAULT NULL,
  PRIMARY KEY (`IdArbitro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `arbitro`
--

LOCK TABLES `arbitro` WRITE;
/*!40000 ALTER TABLE `arbitro` DISABLE KEYS */;
/*!40000 ALTER TABLE `arbitro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `compite`
--

DROP TABLE IF EXISTS `compite`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `compite` (
  `IdEncuentroJugador1` int(11) NOT NULL AUTO_INCREMENT,
  `IdEncuentroJugador2` int(11) NOT NULL,
  PRIMARY KEY (`IdEncuentroJugador1`),
  KEY `IdEncuentroJugador2` (`IdEncuentroJugador2`),
  CONSTRAINT `compite_ibfk_1` FOREIGN KEY (`IdEncuentroJugador1`) REFERENCES `encuentro` (`IdEncuentro`),
  CONSTRAINT `compite_ibfk_2` FOREIGN KEY (`IdEncuentroJugador2`) REFERENCES `encuentro` (`IdEncuentro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `compite`
--

LOCK TABLES `compite` WRITE;
/*!40000 ALTER TABLE `compite` DISABLE KEYS */;
/*!40000 ALTER TABLE `compite` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `crea`
--

DROP TABLE IF EXISTS `crea`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `crea` (
  `EmailAdministrador` varchar(30) NOT NULL,
  `IdEvento` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`EmailAdministrador`,`IdEvento`),
  KEY `IdEvento` (`IdEvento`),
  CONSTRAINT `crea_ibfk_1` FOREIGN KEY (`EmailAdministrador`) REFERENCES `usuario` (`Email`),
  CONSTRAINT `crea_ibfk_2` FOREIGN KEY (`IdEvento`) REFERENCES `evento` (`IdEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `crea`
--

LOCK TABLES `crea` WRITE;
/*!40000 ALTER TABLE `crea` DISABLE KEYS */;
/*!40000 ALTER TABLE `crea` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `disputan`
--

DROP TABLE IF EXISTS `disputan`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `disputan` (
  `IdEncuentro` int(11) NOT NULL AUTO_INCREMENT,
  `IdEventoIndividual` int(11) NOT NULL,
  PRIMARY KEY (`IdEncuentro`,`IdEventoIndividual`),
  KEY `IdEventoIndividual` (`IdEventoIndividual`),
  CONSTRAINT `disputan_ibfk_1` FOREIGN KEY (`IdEncuentro`) REFERENCES `encuentro` (`IdEncuentro`),
  CONSTRAINT `disputan_ibfk_2` FOREIGN KEY (`IdEventoIndividual`) REFERENCES `evento` (`IdEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `disputan`
--

LOCK TABLES `disputan` WRITE;
/*!40000 ALTER TABLE `disputan` DISABLE KEYS */;
/*!40000 ALTER TABLE `disputan` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `encuentro`
--

DROP TABLE IF EXISTS `encuentro`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `encuentro` (
  `IdEncuentro` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime DEFAULT NULL,
  PRIMARY KEY (`IdEncuentro`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `encuentro`
--

LOCK TABLES `encuentro` WRITE;
/*!40000 ALTER TABLE `encuentro` DISABLE KEYS */;
/*!40000 ALTER TABLE `encuentro` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `enfrenta`
--

DROP TABLE IF EXISTS `enfrenta`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `enfrenta` (
  `IdPartidoEquipoLocal` int(11) NOT NULL AUTO_INCREMENT,
  `IdPartidoEquipoVisitante` int(11) NOT NULL,
  PRIMARY KEY (`IdPartidoEquipoLocal`,`IdPartidoEquipoVisitante`),
  KEY `IdPartidoEquipoVisitante` (`IdPartidoEquipoVisitante`),
  CONSTRAINT `enfrenta_ibfk_1` FOREIGN KEY (`IdPartidoEquipoLocal`) REFERENCES `partido` (`IdPartido`),
  CONSTRAINT `enfrenta_ibfk_2` FOREIGN KEY (`IdPartidoEquipoVisitante`) REFERENCES `partido` (`IdPartido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `enfrenta`
--

LOCK TABLES `enfrenta` WRITE;
/*!40000 ALTER TABLE `enfrenta` DISABLE KEYS */;
/*!40000 ALTER TABLE `enfrenta` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `equipo`
--

DROP TABLE IF EXISTS `equipo`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `equipo` (
  `IdEventoEquipo` int(11) NOT NULL AUTO_INCREMENT,
  `Nacionalidad` varchar(20) DEFAULT NULL,
  `Nombre` varchar(20) DEFAULT NULL,
  `Alineacion` varchar(20) DEFAULT NULL,
  `IdEvento` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdEventoEquipo`),
  KEY `IdEvento` (`IdEvento`),
  CONSTRAINT `equipo_ibfk_1` FOREIGN KEY (`IdEvento`) REFERENCES `evento` (`IdEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `equipo`
--

LOCK TABLES `equipo` WRITE;
/*!40000 ALTER TABLE `equipo` DISABLE KEYS */;
/*!40000 ALTER TABLE `equipo` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `evento`
--

DROP TABLE IF EXISTS `evento`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `evento` (
  `IdEvento` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime DEFAULT NULL,
  `Deporte` enum('Futbol','Tenis','Basketball','Volleyball','Hockey','Tenis de mesa') DEFAULT NULL,
  PRIMARY KEY (`IdEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `evento`
--

LOCK TABLES `evento` WRITE;
/*!40000 ALTER TABLE `evento` DISABLE KEYS */;
/*!40000 ALTER TABLE `evento` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `individual`
--

DROP TABLE IF EXISTS `individual`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `individual` (
  `IdEventoIndividual` int(11) NOT NULL AUTO_INCREMENT,
  `Nombre` varchar(20) DEFAULT NULL,
  `Edad` int(11) DEFAULT NULL,
  `Nacionalidad` varchar(25) DEFAULT NULL,
  PRIMARY KEY (`IdEventoIndividual`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `individual`
--

LOCK TABLES `individual` WRITE;
/*!40000 ALTER TABLE `individual` DISABLE KEYS */;
/*!40000 ALTER TABLE `individual` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `juega`
--

DROP TABLE IF EXISTS `juega`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `juega` (
  `IdPartido` int(11) NOT NULL AUTO_INCREMENT,
  `IdJugador` int(11) NOT NULL,
  PRIMARY KEY (`IdJugador`,`IdPartido`),
  KEY `IdPartido` (`IdPartido`),
  CONSTRAINT `juega_ibfk_1` FOREIGN KEY (`IdJugador`) REFERENCES `jugador` (`IdJugador`),
  CONSTRAINT `juega_ibfk_2` FOREIGN KEY (`IdPartido`) REFERENCES `partido` (`IdPartido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `juega`
--

LOCK TABLES `juega` WRITE;
/*!40000 ALTER TABLE `juega` DISABLE KEYS */;
/*!40000 ALTER TABLE `juega` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `jugador`
--

DROP TABLE IF EXISTS `jugador`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `jugador` (
  `IdJugador` int(11) NOT NULL AUTO_INCREMENT,
  `Peso` int(11) DEFAULT NULL,
  `Altura` int(11) DEFAULT NULL,
  `NumCamiseta` int(11) DEFAULT NULL,
  `IdEventoEquipo` int(11) DEFAULT NULL,
  PRIMARY KEY (`IdJugador`),
  KEY `IdEventoEquipo` (`IdEventoEquipo`),
  CONSTRAINT `jugador_ibfk_1` FOREIGN KEY (`IdEventoEquipo`) REFERENCES `equipo` (`IdEventoEquipo`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `jugador`
--

LOCK TABLES `jugador` WRITE;
/*!40000 ALTER TABLE `jugador` DISABLE KEYS */;
/*!40000 ALTER TABLE `jugador` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `nosuscripto`
--

DROP TABLE IF EXISTS `nosuscripto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `nosuscripto` (
  `EmailNoSuscripto` varchar(30) NOT NULL,
  PRIMARY KEY (`EmailNoSuscripto`),
  CONSTRAINT `nosuscripto_ibfk_1` FOREIGN KEY (`EmailNoSuscripto`) REFERENCES `usuario` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `nosuscripto`
--

LOCK TABLES `nosuscripto` WRITE;
/*!40000 ALTER TABLE `nosuscripto` DISABLE KEYS */;
/*!40000 ALTER TABLE `nosuscripto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `partido`
--

DROP TABLE IF EXISTS `partido`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `partido` (
  `IdPartido` int(11) NOT NULL AUTO_INCREMENT,
  `Fecha` datetime DEFAULT NULL,
  PRIMARY KEY (`IdPartido`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `partido`
--

LOCK TABLES `partido` WRITE;
/*!40000 ALTER TABLE `partido` DISABLE KEYS */;
/*!40000 ALTER TABLE `partido` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `pertenece`
--

DROP TABLE IF EXISTS `pertenece`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `pertenece` (
  `IdEvento` int(11) NOT NULL AUTO_INCREMENT,
  `IdJugador` int(11) NOT NULL,
  PRIMARY KEY (`IdJugador`),
  KEY `IdEvento` (`IdEvento`),
  CONSTRAINT `pertenece_ibfk_1` FOREIGN KEY (`IdJugador`) REFERENCES `jugador` (`IdJugador`),
  CONSTRAINT `pertenece_ibfk_2` FOREIGN KEY (`IdEvento`) REFERENCES `evento` (`IdEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `pertenece`
--

LOCK TABLES `pertenece` WRITE;
/*!40000 ALTER TABLE `pertenece` DISABLE KEYS */;
/*!40000 ALTER TABLE `pertenece` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `publicidad`
--

DROP TABLE IF EXISTS `publicidad`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `publicidad` (
  `idpublicidad` int(11) NOT NULL,
  `nombrePublicidad` varchar(20) DEFAULT NULL,
  `imagen` blob DEFAULT NULL,
  PRIMARY KEY (`idpublicidad`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `publicidad`
--

LOCK TABLES `publicidad` WRITE;
/*!40000 ALTER TABLE `publicidad` DISABLE KEYS */;
INSERT INTO `publicidad` VALUES (1,'logo_empresa',_binary '�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\\\0\0\0o\0\0\0��x�\0\0\0 cHRM\0\0z%\0\0��\0\0��\0\0�\�\0\0u0\0\0\�`\0\0:�\0\0o�_\�F\0\0\0	pHYs\0\0\0\0\0��\0\0L\�IDATx^\�\�	�]U�&`�.�\�Ʈ.��F��\�Qq`d2CP&C$\� \�<GF�IbHBaJH�)	CB2@,\�RѲv�w�����ssι\�\�ܛ\�\�<ߓ\�}\�\�ӹ�[\��\���\�#EQ�(Q�D�N@vc�%J�h=�K�(Q�D\�\�X�D�q\�	\'�{\�.\�>�\�\�c~�%Vwd7�(\�j|\�;\�)\�\�k�\��\��~�1�O��;�K�h5J\�-Q�$\����pK�(	�D\'�$\�%J\�-\�I(	�D�\�^~\�ŕ\�W<=i\�YiۢE�֯ܧY̚5k\�\�\�F\�\�\�O\�\�\�(fϞ�yn{�x�\�\�\�m_�X�`��\�\�`\�\�\���O�\���\�*�8�on�F�\�{��p\�̙�in{�x\�W\�\�mo����ڹ\�\�\�_\�0��Q<\�\�s=r\�ų\�>ے\�̛7o\�\�\�F\�\�k��\�9ë��ڒ\�\�ܹ\r\�\�\nn/\��\��|\�K\�\�	Z\�\�>|\�\���nZl\��S�\����\�ܙ3[\�I~\�[\�*n�5ٍ\�L�|\�n��T�\��?]\\\�aӊ��X�0�\�G�;m\�}�\���\�\�>�\�b\�@�\���۷��B�K\���nZp��g���u\�z\�.��\��\�\�P\�~\�Ƀ\�\�K�^�\�c��\��-�\�o���?����6\�\�m%\�(Q�p=z�q�\�Z\�|\�\�ł0�\�\�\�=z{l�A��\�>V\�\�r\�\�|\�\��G���FE�M\�\�?�\�b|�mBI�%JTY\ns�~z����\�\�=\�(f>�x\�´iŠ.(zm�Y�\�\�;4\��K���м.\��xm��\r\�9蠥$��ZkE+a�\�|���\�?\�}��(	�D�\Z\�Cw\�=\�yǵ\�~\�\�ԩ\�\�O>Y\�v\�U\�w�ڪ�\���_���|\��+r�-ѵ\�\�Q\��\���\�^�8\�\�/�\�~�\�\�}\�)�\\tQ\�V�fns(	�D�\Z��`\�\�N(F^�ϦM� j�8?�8_[g��v/�\�w�\'ǎ�\�ŋ�\\XT�\��&�\�\�G\��\�\�E_\�Hf\�c��۷#\�]\�\�>eРA\Z�w\�1��!K\�\��藻���\�W.\\��p:\�.�O[�\�\�;\�\�Ag`fx��:#w]9<xθq\�.N�_\�9��\�\�ם~z1��+\naC&\�(]�\�B����G��\�\�\�H�h-\�\�tӂ#�ۮ\��\�/��\�f\�M}E�\�\�\�(t\�\�ٳg\�\�/�!lF~^�\�\�:\�\r\�\'wm]\��\�7��A�!ܓN:)�O[\�v\�m��;\��Z��~\��_\�^W\�l�Mq\�-�LK�_ဵ\�z\��\�b��\�\�Ĉ>\�\�j&�\�.\�\�X\�կ\��c�.x6��\�й<�\��u����^����\�y�`+��䥗�	-a4\�\��\�\�@�\'N\�{i\��!�R�*��tG\�uݏ�Q\���\�ݯ-\�\�\�E�E\�Q�k\�]O-\�\�\�+|t\�1�;`-\�\n/\�\�\��\�\�&̊�ﾻ8r�\�n�\�\�\�}\�kE�\�7/\��#�\�oaEv\�\�)S:m[\rq�6m\�y\��ydqű\�מrJ�ʸ\�\�ˋi+ɨZ0cƎ\��l�w߽x����U\�\�U�x\�܍�v}\'\�\�[��vq\�W�R��\�Fm\��\�\�ٳ�;��6���\�oؿ\�\�\�}�G�\'Ϻ\�~�\�ٗ�l�\�\�ȑ#G\�\�讄�O|�\�_\�\�\�N=\�\�\�\��EG@\�\�\��\��b�0B\�]K_	\�\��U�\�A\�\�C\���\��ɓ�}�\��+v��c)\�~\��\�\�\�u��\�\�\�~�\�[\��z#ۏ\�q\�b\�~P\�7dȜ��Qy�V\�ǋ�?\�\�;ǚ\�iq\�\�GG�\�\�3���I#�|�p\�\"0L !bi��\�Q�H\�d⁛l�̿?\n�FI\�\rD��\�7\�\�3�\��/1\�\�\�v+��_�\�\��-\�\�\�\��\�ů~\�b�\�: �Θ�_1Y\Z~�\�\"je\�\�	W\Z\�[n�}q\�\�QG�?~G�;��A3��\�\�َ\�e�]��\�u\�\�Yg��]�8\���2x��J\�\�?���\��T\�[\�\�h��fe�!\�m�\�oc\0���;\�T�\�6�\���Hn\�0�E��\�\��h@\Z\�\�\�p\�H\�Ԩ	>aO�\�5P\�A\�/ϙS\�[\\H�\�\�\�܃�=\���^\�Z\�\';�\�l�wW&u쾑����BGRy��+�?>v����\�ҹ�\��X\��\�O\�n\�\Z\��\�\�_�\�7\"!\�8(�{���uTH7\�=_�\�\�{\�1\�d_�F�\0�Mg�;.\�t\�M�\�\�\��m\�\�+ZU�&M�t֞{\�=-\����8�j\�{\��\�m.\�=�\�)\�\�\�\�T\�؅�wŠÑah�\�7�韢כ2�\0�m�\�Zq�\�\�짞jW\�ܠL(X\�l�\��ODO�\�\'?3\�<�E\�\rjۄߔ�\�+^�7��?}z\���\�\�!\��}\�A\�\�C-	�\�ԮN�\�M\�s\�{�\��\�\�7��UT��|\�\�3\�,����5\�Ϸ�\��\�A\�tV��0�\'|\����\�b\�Йx���`\�\�\�\��y\�\�{�c\���\�\�\�v[\�\�+�D�M\��}���\�Oc��π�9{�\��+\�ԩS{6\�\�pJ舫�\�\�\�GqDv��@u^�B\��Z�\�id�j)\�6\�03��\nZ\Z\� \rx쭷N�\�{\�E�\�3\�ug�Q̞:��\�\�+�\�\�\�/\�\nHQU�\�\�9]ԧOTU�`�0��\\y���8�\�@\"�R�q:v<�\�>�T]#\�\�[l�\�Y�?\�z\�9���\�_��n�p֬B�\��\�>~�hQ��\�\�!\�>\��\�Ƴ\�.^_�p9�J\�\����[\�;\�\�Xwb\�\�׏aW\�\�y丰K\�>Z�3{\�,�\\\�\�:9߇\���\�.f>\�Xa�\�k�)�>\�D\�A\�\�\�\�ł3bG\�\��\�\�<�\�\�rW��\��\�j]�p\�9眆���@٬�\�q�\�\n�\�w\�}�\���\\-|3�VU��ƈ0\�\�n�\�\�\�E\�q�s0\�D�\�g�`מ|r\�\�_�:*$/9OЄ\�͗\\R\�\�\��S��\�\�{\r\�y�зW�\�*�#�\���\�7\�\'�Ȱ��4\n\��C�\n֌;bu<��\�v�\�.��\�\�1�\�~�_}u1sʔ�`�\�߅C�XX\�\�s�\���mP�Aa\�\")Di\����]���z\��@`lD{Mx.�Z\�[\�\�\�s?z���\�=�-�`B\�*;���?>�l\�tr�H�߇{\�\�w����я�w~�\�\�\�_�\��\�\��\���\�/\�\���}供on�\�\�U	W�\�\�v\�-�\�4�\�����\�\�(��&жܐ�\\-l��\�\�\�ᝫ>V{\�\�/lʲȝ�L�Mic\�#�1\�\�zMD�yδi=Ʉ;\�C\�\��\��E\�\�޿��f\�FG\\w]$D�l\r\�͞��T�\�75�O�\��\�m�`�SC}\�/r\�+\�EA \�K\���^zi�3\��\�\�\�e-k��\�/#�.�93^�ῆ�^|\�\"�V1\��\��c6i\�Z���X\'\�uW��z�h\�I\'E蔾\��/DU\�\�=����$E~��e�w:#\�}C�\�\�\�ސ\�\�\r_\���\�\�\�\�{\�Y�>�Wu\�y\'2�Ux.:��_x�x;o \��,\�V,z��h9�Ps�\�QM{\�U	\�.V2\�\�4�wВ?_Gau!\\8\����k�9lذ�\��5\�\\\�a\�\\����#�\�\�T\"���xQ�)�WL���\\xaTx�=<jT1\�\�\�\�˾S ާI\'�R���j\�d��:E�	_�\�\�\�\�/})z�g}\�[�l�\�\�\�W\�\�X�8-\�%g\�b}\���A\rR\�HJڲ�@\�\�7#(\�Gǌ�ʯц�f��������KA�\�\�\�+\�\'˃\�7�:��\�m�\�\�;.�Y\�ً�P`HZ��\��\�B�by�\�r��\����M�m�~Au\���\�I�\n\�EkF\�3�＊)h�\����jXW%\\ו{yڋ��x�F3�k��u6���\'�x�w\�>�\�c��)�s\�\��%�\n<�\�\�\Z\�^\�\\� {e\�Fvc%f=\�\��3+VXP+W\�&\�\�\��\�Qm�\�\�\�>^|/\�a�j\�\�z�F7[k�\�]v�\n3����rq\�;\�!�����\�_\�\��C�F��Б8�V\�\�\�n�!\�;\��\�\�dA �	\�\����*Q��ʆt\�\�zk��\�z�x�\�\Z5\��\�\�;\�f\�J$�z\�*N	ģ��Jl&\�>\�\��й~\'e\ZQ\'�)(Z��\nD��\�\�O�c<�kUa\�\�<�d)��u�cs�O�G!�h\�;�w\�3ϰ��[A�\�!헭\�d�|\�}\�u��p[9#M�l��\�ٗ�^l�\�&ſ��\�\�\�f�\�B{V��$\�χ\�Z\�\��\'\�/�C\�\��L�\�\����O6\�N?׳\�˱\��\�5{\�_�\�\�\�	2\�n�\�C\�\�1��g��=G%6\�t\�b\�7��\�\�֣��+\�ڢE\�:t�`��mN \�Q��D=:N\�P��\�\��HS�\����l$��} ��\�3��Ԩ\\\�i&�\�\�\���+k.\\\��\Z\�6iVA!\�ꔠ�ǆ{uО\�\�@̿�\�o��T�!q\�Ǐ\�0�ꦠ\'\�qG�6�\�ǆ\�s�\n�v��\�\�:\'>82G�\Z\�\��A����\�\�{;\��F\���_���\�\�l \�g�\��A6-\���j\�dH+�U\�\�PBI\�K\�(@�pM©�;wG�¥��S�V-�\�,�e2�\�WF�\�\� �t�c֋{\�w@=>2\��\�����X\\GM�\�\�j�a\�:��W\�\�*63� CUj\���o.)\���\�\�R0\�O�\nQ2\�=c���\�\�\��\�_t\���\�@|^~�ۯ�\�\�F\�	�= vv��<�B|\�[a8-�mU���\�_�2}�\�w�W�rg\�;xp\��\�\�c=bĚ\"=x�»x\�:*�\�(!5\�\�{�\��\'C��#^#6��3��G\�T�\�n\�l��;\�*Y\�o��\�j�\�}\�\�7�\�!c���\�;\�Eh^�\�\�v\Z�\�!\�U�\�H:w\�m���K8hFc�c\�\�\�ä�\�U�\�\���L�\�P\'A\�B��\��\�H�^`^lޥ\�/��PyB�|\�Pw����M\��_\�\�\n�iHׄ\�\���E\\�\rQ\�\�DT\�c��\���\�{#��\���gV�\�4\�G\�F�X훚g\'�X\�\��v<���HD\'ɮ�|)^��B��8k����\n]�p\r\�	�����A�i$\�Hl\�\�ѣ�\�\�\�j���k�\�f<v\�Q��z\�?\�C ��\�/\��\Zٍ� \�\�\�v?\��\�C����|��\�5!D��1\'Z�Z�T�߱LU�Z���m�\�տ!\�b�O~2�xI�xv\�\�$�;5ʕ-S\�\'z\�YT>[\�\�6\�^\Z�08M�ď\�\�{r<\�\�Կ\�	���E/,\n/\�\�w�����+>z�kɽ@�񭯾�\�\�\�m�\�;�\�\�@m�F*\�\�\����:�\�\���p�F\�^zi�FCҌb\ZY�7��\Z\���jP\\T��$?�mMv�`�\�=�80�Ņ\�p2�|�\�\�\�EO\�#�=\�\�W֙D\n\�U\�\�L\�yC񯆡�Y��A\�	\�J^gwi��?{\�ͥ��\�\�\�\�N\��hװ�E�\Z\�\�\�>\�\�d\�9�	2	\'b�y\�^n\�\�\�\�\�V\�YM\n���8���\n\r\�J�+/�u+\�?�\�}\���.:?�O-\�\�.Ř1c�T_C���.\\�fs\�\�|�\�_}Ch�\�\�U\�	�5X1��\Z\�o�\�k�\�00d��l-d��\�\�QMRXW�U)\�sѬYqHk\�\�\n\��f\�\�q5�JLhV�:>BB\�\�z�O#-�?�1��&j*\�sI\�����`�\�J�o�Z\�\�\�\�<߃6\�4�bM\'\��1\�)\�5��Y�\�ĳ?��\�\�Zk\�\n_���l&�$\�\�\�Ž�曟M��\�\�\r\�\�r�\�`\�ٷ\��΄+\�\�\�\�G[�[���\�\�&7�n=?\�\�\�Y�AT��[\�g\nW\\&%d\�\�\�s\�\�O\�\�\�#1�T*o\�P\�\�\�3���\�\�B̧Ϩc ��\�(\�\����^��U\�B-\�6\�L~�6@N)FU2@�\r\� \�\0\�$\�Gh�CX�:5��HݣNE\�\�\�I\�\�Q�k�\�И�\'�Yz�N\�I�bd�\�K\�x\��[\�\�x\�q�NG\�\��e8�\��\�\�*�\�\�ʽ@��\�{ӧO?�\���r\�\�}kA�\�iӦ\��<F��:.0\��F�u��D\�Ǫ�\�F-&dΚ\��-d7&��q�\��o\�\�^���7_}5�\�\�\�\�\"{yy�j*P�&\��O7.� I�Ր*��f\�\�\�\�{J�\�\�#�F[Rg\�k�[�+Ԫ���$>\�=%JP\��j�M\'\�z\��\�3􌐯\�Q���\�\�scfYe�,l\�s�\�g#\�j\�̨CGb2ӄeP�1N�\�\��0��\�\Z�í\�\�(�\�Ο?\�FWt��\�\�\�y\�\�w�E{ꩧ�\�k_�Z\�*W��W\�Z�zZ�՝p}w\��\�a�\n\��䎙`ҫQ27�V}�z�\�X	/�hQ\n~6Sn\�!yQS�C�\�j&�d�\�����\�a_\r��)+j@���\�)A�Ԛ}\ZmĬ>BA���\�n��;>r\�HVc�\�}U4\�\�@��\�\\bL��V\�\�\���d��PXȈ\�s\���D���\�\�\�$�*�\�J\n\�=<�d���O�ы\�_�\�\�X�^t\�\n�{yjARĸq\�H��Tn�\�gj�w\�\�V`Vw\�k�I(\�\�O[\�{\�\�\�\�\�|<�\��>\��Z�\�D\�q\�Evc%D&x\�\�\�\�/\�xR\\^v\�#axjBLR��Y\nIp��)U��\�\�ax�p\�\�e)\�{\�\�ʰ:7/\�\"��i�\�\�̶#9\0�7\�x���	i�Vl�Mɯ*/WG\�\�0ܧN5��\n\"E�\'^y}l\���\�ԣ�\�;#ͧ�5�.ف\�/O>��	[\�\�r<�\�p\�\�vN�t\�\�e/����>�\�E�},w�ѣGo��L-\�DR\�5w�V`M \\87��f��Zk��D�h�\�gj�=\�\�e7B\�\�8\�Z�\�\�9\�2��\�s\�M1\�\��\�v�/7�^.jI<-\"�@���A@�y�M�)��@D\�M�i|N)�\�콊Y�\�z\��\�AR�BքP����7\�nȝ&WEC��\r��M\�q:�\�a\�\�=T6Y{֘\�}P��^vYT\�Gl�m\�4�f�u�F.�v�\�\�{���Ey鰪	w	}�	��A�m�;̝;\���\�kC��H���F��.E*k1wOm�G���Ǖ\�\�\�+4�ۿD�T�Qd7�I3�ei�+��G�\\�kX\�_dI5\�\\2I�Wv�\�R\�\�R�fí�\��W�\�\�dBQU환2yGղ4�\r�\�\�6J<%[f+-�\�:�x\�*MvfsH?v\\\�:X�e\'u4V�H\��!\�ۯ�ji� \�ռP0�\�>}\"��4љ���V\�~\�Ƀ}\�\�b\�d˥�6�UM�\�\�\�^�Z8蠃\�\�S��\��\�\�>[&ZV\�\'6�5�p�ZU7!w_�@\�R�\�R�-\�۷�^T\�&�d7&<\�\�C�(S�bx\�M\� \"���\�]��\�(?$*���&��\'!��\'N�/?OPT�\���jC���%�jH֔\�]�C\�&��i:\�a\�\�\�bo�akH�omho6�\�p�bg5\�&B�%��bu\�=�Vs[݄w�$��\�a&&�F��)~�\�d\� \�\�B6�7|�\�\�\��.���$\\S\Z}A\�9\��rǪĴiӾZ�\�\�\�W8>��dP\�\��I�+��\�\�[\�\�{�jC����}k\� ^*��d7VBd�\�~U��\�CO�\�3�\�o��U\"\\usM<!	dHٚ�V@\\���\�\�\�M�Q��YQ�7\�L���7y�6�2�\�Z:j/�\r�y)��\"UX���B\��*t,\�X3H�\�Me�*\�\�zv,޹�Ges?\�\�&�\�[gC��x\0ٲ�_ye,yϠA-\�\ZW%\�^|\�\�\����Q�F}<w�j�}\�ٯ\�Q!\�[\\%�5�pA	\�FWbp\�T\�\�7\�<C��\�>�\�o����!\�a���73Y��\"�{\r����\�n\�\�z���`8�ɌJ����r-�.��K\�+E��\�1QƧl4\��䎬+u���\�V���\����d\\Qڮ1�Pq˥�\�\"\�V�Hus��6)x\�\���\�\r7\�\\�\�R\�$��;�\��\�\�X��ˇ�\��A\�\�\�\"Z!|\��)o�\�o�*7t8\�D2���{h��p%\�^�Z8ꨣn\�\'�aÆ]\�E\�\'�vD�\�fW\�СCgt��\�V��q�<{�\�B\�6����\�[vc��R\�\�J\�ЛJ=6H\���1{�H\�\�2��\�w\�o�$�F�\"d�+��^�L\�9��\�m�鈞����k>���&\�\�D�aǳ\ZE,�\�]b�C\��\�oc\rמ\�c;�I\�e\�\�$�L�\�R�U-�\�f٣�rUo\�p\�N;\��i#��+BnAP\�\�G��bU�\�\�KTƌ�K\�X9̛7o�@v�\��ĆZ�%w�f\�(\�v6N:\�p��ko.ܠQ��Q \�SO=�hUY\�\�\�J��8ey\�\r����\�P�\�\��\�#!TH�2��\�+̐�Ǌ��RfO\�EP\�\�6�\"K\�\� ��O8!�I�m5�c\��5Qb�ݗ\�\�.�T-8���l�M$]�\�\�\�qTxG�Xm-d��~�!\'��3P�R�D�\r\�\�\�\���|�\nL^�@\�i\�a/����\�^�Z\����\�o��;V-8\��FUt���6�\�kk\"\�Z�\�\n<��[4qٍ�x\�g\�\Zp�q�Q\��V�\�\�T�\�*����Dj\�\�a!5\���\�}7\�8ζ\�\�\�\�O��ĠR�g�q�ᅈ��\�(ҥ\�(iI�Hk5$i=/��Aݚ����\�u\�h��mu�����e&\�\�\�Vj�J\�3��\�}Z ��\��۫x�+�rD���U��Wx�]Su��W\�\�\�b`)�.��\�\�1b�܋ӧ\�:Ӗ�gr\�;�p\�\�{j��)d��t\�63\�\�s\�M�c��\�\�\��S���ֿ\�,Z��o%\�\�\n�7�VǪ\'�xb�\����V�ȝ�|\�++d��V/��ݘ�`�яM����\�+e\�\�6�Gp&�\�xȔ\�54EP��\�\�?8찢\�\�?_�էO$%\�\�\�œ\"]�Mh�aaӦN�ag��I�\�HT,m�\�<|g\r\�Ny\�b\�yq�4�UHԽP\��\�ց�v\nm3Iƶ��\�\���\�\�c\�X��J��\�z\�\�\�p\�7Ԭ\r*\�gR\�\���N$jl�\�:\�ea�F�	\�3\nQ�M4{GD�Z\nҵ�\�d\���o?4\�\��\\\�ٿ�F�&A+7\�\�c��kyu�FA�\�\�dΝ;\�\n�\�㵅�}�nt�\�\�\�`��V�\�\�~\�K_*6\�h�\�\�>�\�\�f�7�υ��\����E�a�	�FF2�\��4N[\�q?[�\�M��=BvcBP�\�>�\��\�|S|���\�g��\�g2\�d�\�%/�Y�Dzo�rDM\�秒\�[M^���9�`�z��V�`�5	\�\�פxn[ĄD)i\�T�\�C�n\�	�t̒�\�M��{U\��\Z\�F��Hҕʬ��\��\�	4\�At]_\�*Ru�S�=�\�V�碣@\�\�\�\�\Zrg�\�\�Uj�=V\�X@.ƺj&\�\�\�\0u���:\����),�>����m)��\�\�K���9星�\�w�\�f��#G��\���\��\�ܱkA]�\�\�4�5\�RH�a\�\�y���\�\�\�n�D \�#�\�\�\��[E�\ZE�\�\����Cl\�o\�I�)�Z\�\�Q��\\��ܛ�\�^�\�\�p����|�\�C�m5䇜�	\�A̭$	���\�pܽ\�2��2\�\����\�8i\�5\�I%\�&x&ם~z$˨n�<j\���\�\�g�\�\�S(��&e\�\�I�\�\�\�	�cr\r1{�F\�E���\n�\�\�\�\0��FR��\����b(y\�\�s\r-�\�\�\�\���	\�\�Hʦ\�\�\�\�\�ߘ;V�\�ӧ\�m�cׂz��\�rKK�\�^\�	W\�V�5j�H��*c\� ��\Z����5���O\�^�b�[�) \�2��\�TE<*\�p\�ˬ\�\�qh\����\�\�\�R�&�,���(\�\�\�\�ʆ\�\\\"�0�W�q#Jަ8aeY%��NF\���rי u	Hqz&B\�\�zi��:[B\�5]\�$N \�\�ӲC�M:o:W�Qk�\�jF|V\�3\�tzï�\"�\\	l�\�D�\�\�=S�֔�?פ�\�f�\���I�\�\�\�\�ٗ�x\�\���v�\�Ջ���j���\��/�\�\���>N3X\�	�\�\��^\�܍B�t+\'\�*�ݘ\�\�=\�,-XbUW*\�\�O\�\�\0M�QI�\�\"@�����)-\r� J������v���%b\�\�ʀC숏bm+a\"�7\�+\�\�DEi��27k��OԄHJ>������\�\�tS��eH/j��ķ\"8D��w^o���\�\n\�_\'���\� LJVG@I���\�)E�\�\�w�y�������\�\�@��L�\�>=C#\0�\�v*WG�|\�Ԩo5\"�\\!bQ\�R\'\�\�\�sΉ#���\�]�\��I�Vth4j`\�\��o�\�~��X�b��\��;w�Z\�\�H��/	\���\�G�=�\�wÞ�>v��ݘ \�\�� ����\��\�lL�=��h�^C����1\nR��I\Z9�HGC�\"):\�R=�\�V���\�`�A���/\\�BX\0i�\�\�\�~\��\�)9׎p��!5�@CX�2D���b׮\�ѐq�\'\�\�\�\�ɢ09�Z�\�e�\�NA\�:\�ʚ�P�&�M\�[�	$j$\��t,S�▜\�>\�u\��]#\�)K(с��\�\�\��U6\�\�\�Ȥ\�\�N���\�u\�X��׾\�y\�\�C�\�^t\�>\�\�S7Z\�{\�?��⋯\���\�x�\Z�g\�~$�\�/62y\�;�\�[}��$ܿB	\�FWc�\���\�Y\�Bvc%,�rW�\�T\�\�N\�RE�����6\�\0)yaM\�\�n),D�\�_䄐�HDh\�]T�^\�(@ջ�\�V*d\�z1��\�!t\��	�GK\��KA\")J֐ڱ!NnU�#6\n\�u\'\�=\�b��ZW\�@\n�$\�2\�-\\�I5��\�u^$�\�\�Q\�<L�!]d\�Ovj\�3r!tRpuX\�5\�\�ܮ\�u�}L�)j�\�B�ʵ�t\�-����8\�#��\�\�\"���\�.Y�ekqu\�^{\�\�cs/S[>\�Sm/\Z�T\0\�\�\�\�j�p�=E\��<P}\��K\�ԊNi>s뭷�$���A\�\��\�\�y��V(�gi\�%EP�H	.KrTO��h@\��j\�S/L�ɦ�(k5*NJ�U~�鼠��l�eR*5\�a�\���\�3�\�\�QP~Ȑ\�JM\"Q\�ᳲ\�\�\�)$�\\ݐ�\�Q���\�K�\�g�\��!�� %%xv\�\rHY\Z�L=Q\�(\�Q\r\�\�7\�0\"\r�c�^:9޵�{\�qQ\�~\\\���\��\�\�\�*T��>%KP\�:^.k��\�9M�\�{���\�\�\�(:�p,X�A�v \�\�Ʃ6C���w��\�hE�za\r�fJ8Z\n��X�Fv#̙6���֠\�\����wT�\�HKz+\�ыm�\�%G\0|\\�Q^\�;��&z��ZcѤUg�l\�B�+k\�d�8\��O�i�\�\�\�\��\�_Aa^)A�\�\�3�����!�\�MZ���V�8\�D\\�g��6�ek�\�\��\�\�=\"g7\�K�^\�!T\��8�\"@\�ċ��ZquP�7�\�=b\�\"\�=ÈB\'\'TK2�\�,5j�Қq=���2�n\�\�\�N��ss�֓뽤\�\��\��x}?&\n\�(�\��7/n��\��K�P�����\����\Zԍ�Q¥\�s񚶠\�U�6w\�m��[\�x�Dvc\�\�\�3ZR�ѻ\�\�+\�o�{khL\�!\'	��^zCa\�\�ʽc\�>\�)�\Z\�RK\��?\�3�S[�O,\Z��U+^\�\�/\�!X\�ѐ%\�\�\�\�#�D�<U\�`�8\�$���\�Q\�?��\��\�\�\�\�^\�.��눐 5o��ܔv<:(W\�rA�)\�\�pA�7ExN\r/�!�)���\�B\�s%\�V6\�\�ĳHī\�`�\�\��\�\�t�C�����P\0G�\�}A��ݢ\�&\\Y[��{��X\Z홬)	w�%\���&�(7CR��\�\�\�&¼���}:&xx�^Z\�}�ȯD^l*5ř\�}m�ʕk�\���L\n��6\�fx\�jP*1E!�\�1`�\ryQ�~��4\�9��:ǧ\�y\�m�\�ꆰ�\�E�V�\�\�:$\�\�x:\�jE]��H�k\�#t�{l$:��\���m�\�\�\�\�\�u��\�&�\�\�DX\'>b\�\�\�+�gx~ D%�\�➮1�aӒߎ&\�x��߹��\��0\n�={vSC\�p��[�\���\�HQ\Z\�\���Z2\�H�1e\�\��I\'$G���P(\�C�\"D��b1H\�*\"��i=����]��l\�4Ż\�;\r��XZj\�>�ZJ[��\�>\�Ȉ\�D��\�>)s~o\�i�Lt�\�\�@�j4\��S�\��R��\� B\�\�G�\�/܇\�\�-{&%^h\�!jB\\��v�\�4\�(�\�v\�\�����\�O\�,\�\�V6�\�^>3\�C\�\�*uM�&er/Qw�\�\�;�\\�$\�e薄;m��\�s\�Cf~)/\�l;�C$\Z�A����\�N��C�]Gn\�\Z\� \��!]\n��\�E�p�\'s\�jQg�\�5qG%\Z.���\�\�����w侮݃NB��\�\\ga!E\�t�T\���\�n��>*�g�CIM\��iR��T\�?q\�\�\�d�\�&���+~9�\�iԫ�s\���/\�uz��\�}\�\�5\��#nu x\�R�M�}7|�|`ϣ��.\��)<C+�\n-�\�\�(:�p�x\�ޖ?ɽD\�	&Ϛ�\�/	w����\�=((\�w6���GF��BR�\�>��=>\��\��\��a[��R�\�\Z5I\�\�o)3Y\\��iHK\'@��\�q\�_�����~����Հ\�)\��Ώ\�)sQ�)U�M��\�`tF\")�;\r\�)~DKS�:���ê��g\�T�\"a?\�!\�i��\�dh�\Z$\n�MGB?x\�-1	è@�\�\�-C\�sjS��F�\��ӧ7U̥\ZI��ּ\�ʐ\�\�\�\�g[(	w�%\�\�\�\�\�v\�daM^T3��q�2wn$M�-(l\���c\�\�׿�\�ZDC\�!d$DE\"Z��\�&�՗�\'\�\�(�C�\�ӨD��{������W\�s��H\r��\�\�\�\�#=�\�#udU\�\�]#\��R���t\�\�\�|\�\�3hP�7�\�:$JP����\�YI\�\�\�h9\"�b����b\�>\�H\�3w.�9k&\��\�8�[~�\�&!+�\�8O��\��Z\�o�t\�ZluP�	b�\�?��pk�����p��[n �M\�\�\�7\�r~����`\�GCNH\�!\�f&�\�G�f\�\���rA��\�2�I\�z\r��CW�\��\������iT�kBb�R\�z)F\�\�H\�>�\�h\�ؑ\�H�\�9�:C~j1\Z�_q\�q�|y�|\���ͨ\�݇�\�D�{\�Uv��N灄M�!e\���/��Qo\�q�S\�^#�\���a����qR��p�mB\���ԋ�\"\\�\�^�\�fr�K\�]�nk)<�6\�\�X\�\"\r�\�K�H�:	5�­p&*\�RW�CjL=Y~m\�\�\nJO�iZ#L�\�^a\�ʪ\�Yd�\�k�\�gS6W�\�5�l%�\"�\��c4\�9\�\�Z2\���(Sd\��\�΋!l��p.��syv��\r\"�\�s7\�\�yQ�:\�.2٦sQ�,qˬ\r\�/^�0	�n\�\�\�\�bh[�~�b!,L�pA\�pP\�M\�j��\"\�FV\�\nR��ڪ��iӦ\�TW5w-��]!�$\�e趄{\�!�DzyP`&ʼȬ^��Sn&}�_9zi�J��!s\�\�\�S\Z��첥C՝\�[/\���/\n\�@�bA\��J����E8\���Z\�~�����97\��\�P\�P�a(\�/moC�wr���\�\�Ł�bH] Q\�x\"�W\�\�r�\�\�vm�.,�\�+�eM�sN�*xT\��˵׎Iל|r�>�+�\���8�(\�v�@\�:A*<�\�\�I=8�\��[N�V_ͽ8m\�7z\�,�ȹk��\�\�+P(\�\�\�꾕�[��Ek2\�V?\�N\'\�\�R�\�\�kZ\r*��\�\�6+F\r�a9O���v)Sjbc��\�p�\'b�O�Qˇ5p`\�\�O|\"�W\�\� aC\�Ԩ69|F+Kx��\�2�D�!�4)�m\�ԩ�ti\'\�S�0�\�9s�wB�\�\�Q1{֬\�\�\�\�s\�\r\�\�p��	7d\�9\�S�)\���2$��A[�^\�%\"\�\�!|�m�d\�&����\�\"��~t�\"\Z./\�9\���i�\�#\�\�ڸ=z\�h	\�>�\�\�KI\�[\�\Z�_�� �_��Ͼ\�N\�^	�\�\'L�8�\�V[m���K�T���.D\�x9$\�E&�\�\�89\�C��*Q�\�sϵ�jB�@��\�\�X\�~!�\��\�+lo�p]\�>�\�\�K\�J\�ϣ�\�y\Z�\"O�O\�tP�|1�2m�?^�h}K���\�чU�K,�I�\�u����[�L�k�Qo|]jK-פ�)-J�G�c��\�j�ƻ�\�h�V5��La�B&�̈�\�6Q(�\�ě�>#\n��j��:,0�pLuo���#S\���Bʶ\�4�x\�\�`�\�G�\�λ~\�\�F\�jK�L~\��2\�:�\��w\�x�ŋ�\�L��C\�w��\�g^Z\n\�\�\�,��\\U\r��\�W\�?d y�\�.�<��+��\�a\�:D\0��~/�I$ɗ��Z�l5�pZr=�\�K)�~F�&�V\�F�S�F\�M�l=KuL��%b\'�@�&�Q�\rҒA�{@��E\�\'��+>N\�\"X\�\�\�w|Ix\�֨�\�ă^�饽[M��z\�ʾ4���=���H{�l\�v\�m���ZP+wذau�Q\�2t\�\rC\��B\�D\�.z��\�=z�I\�T��_ۀ:��|�5\�%�dɗ\�qX���\'[�r3,f) \�V\n/�Q���f\�]\�W���յy.�\�ԮP��7\�GG�&��\� <�U`\�\�g�c4!\�\�G\��\�x\�▁]47\�y��t\�gh+|��D+	�Jm��\�9Ez�\�u\�Ν�q\�޽�\�\�x\�\�\�ʡ$\�e\�V\n��k�\�\�\n��̲�okF\�<����5�pu�`\�S\���8^\�ge\�$\�rF0�5,d��a�G��\�_C_� �jP\�ETuו�\��Y\�m\'$sx\�S&�\���<��ţ��T*\�\�{\�e&\�<����\�\�n\�^Z:D}-�a\�r�\��mC��6�V�b֍֝m傍͂�������\�\�U�$\�e\�V�+l��[j\�d�Z\n,�%��\�\�S�W\�\�ߐݠ\�0�V�fu3�\�e\'�l0�#B\�\�U\�8e�i7�c�\�\�L\� e�H�&]\0i\"���\�HQjE\�(H\�\�lSoB��\�7Zo�O\�|2\�X<|\\\�F@�r~e\�u׽\'[0*�_�\�\����h\�:�F\�+\�r\�-;tٔz\�\��^�m\�\Z\�\�A\�T�\Z%\�.C�\"ܕ-��\�\�N�0�o\�w9(5H\�\�ѯ5\�e��\�\�\�{\��{���dsu\r�\\��.o\�,�XS\�SYإ=\r\�#1d[o\�ؤ�\�\�\�/U�\�d��R7�7\�\�\�%\�\�D@��	\�\�\'�D9�DIxV�\�X@�n��j1���vke��U�V\�\�W_�!՗{aj��׭�)o/N;\�\�5�\�s\�\�i\�?/	w�ݤY+A\�mG�\Z\�5\�W\�|s�ߋ\0�e�\�r\��e\�\�j\�t\�\�4		&�\ZQ\�<h�2�Ū�Ϣ�&�Ķ�W�H�z�,LR�GB2O\�a2\�b|\�Fg۰Y�\�|n��\�\�\���\�\n\�\�u\�AE�Ƚ09ط�\�Ӫ2\��ɹkmg�qF�x��P\�2���k\�M\�<2xd̘�\�M�>h��Rc�\�\�g3ː,\�\�3\�Q��R��\� k�Wi[҄��\'X\�\\m5\�g��\�g�L\�Q�\�q���\�\��\�\�T\�\�a�\�\�����>�\�?�\�\�l\�8\'e��\rg刡UAX�\�m\�\�֞\�~�\Z� \\�\�j\�e�\�	\�x���fBĨ��TnI�˰\��\�pDj\�<�p�&�����_\�$P��+E.�^�$Z\���t�\ns2)g���\�|l�PZ�\�$XO_+\"�b�0\��<?�ن\��O5)\� �.� q\�|\�����\��\�H\�E\�Z\�*�:��с���\�xL��]�\�CW@+\��N�\�\�Ԙ�>Ϊ��]ו�\�Z\"\�!%�%\�Z�Ѫ�\�H\��-���\�p�\�\�#�\�1[�\�\�V�Ky�\�lj�&�������\�ZMᖴD%�l\�2\�\�b�\�H5\��\��c�*r2\�F�+k��Q�\���R;�=D[\�\�k�\�O��\�l�\�_����%\"�\��\�c�0/Yz�dץDcZ\�W��\�\�\�n\'6Y��3\�^\00dȐ9W^ye\�Fu��\�2܃n\�^�\�#\�\���\�>W�\��M�\�\�r\�\�&O�|V\�X�Dvc������\�\�_�&Ňpy�\�Gv��i��\�\�\��.��!�f\�~\'\�\�ې\\�A�m ��0\�\�\Zŉ\�	V7j�z\"\�gX�qeM̬\"?H\�\�p�T\�\�q\�\�\�t\n�7���v&\�d�ynT0[�� \�s�\�\�w@�x\�;\�*hդY�\�ٍ�R�\�*\�o�,)��X�Ar\�&4\�t�A\�ґ�\�8�4�&/�{\�\�G\"OYni�pjd-�\�܇\�Yv�,K�W�HV֐�4[a^&���t�I����t�N\�D�4^\�\��ŋ\�\�\n�S��o#Q#�\n%\�(\���k�q�����8@z�\�w*\�Jp���E\�&EIA\"j�EtbpD��1~7fH��)x�\n�\�CA:,\�Xw�m ٻ�\��!Z7�sN,0c�7\���\�4\��\�\�9\�2�k�K[Z\"H\�qZ�\�\�7�\�\':�ᾅ��e!&�W-�\�\�N\n�%\�(с�T\��\�\�\�\�\�m�C�I\r6ܷx\"��r\�^\�{R�,�ʳ��*�qw\�%S�F\�Z\�ܾH\�y�oC�Fp���f���@�gp@\�Q/=\�\�8\�WoS\�7��U\\��/�j(@�X)}\r\�,qB\����u儛�̿в\�AWBI�%Jt \�*t�4\�w��\�\��ن\�\�aHmQC���\�\�ƛ��j(���L�FԡI�z\�d�`!4\�f�M�\0\�\�K�\Z\�2�\�R�&\���V\�E�m)e��-B���xŕ/n�=\�%��\�\�|%F#8�{�\�E؟=\�9P�\�v�\�=	%�s�\�d�����pK�\�`KA\0DB��3}\�\�Wc\�w\�1L����V\'ȵDR\�\���Z�N�$4�\'?�Հl\��0t�`�\�H�\�l�Q\�V�\�rpL�\0Z\�\�n�\���\�%u/\"��y ;Mx�z�,O\��f���q\�uћ�\�\�c\�w\r�4B\�~]%\�(\����V�Ub\�o�*љR�*��5\�rd�\Z�+$�\�;j�\�c��.��c	\�MBI�B��u\��sI+m�t)v\�e��~\n�% �8\�Φ��M\�!\�d?8�\�7���mg�HcU\�d�	�r�a?\��t�5<i熮�\�Pn�une��Fa�	�lH\�\�=\�D��\���\�TouC2�~\0��\�\0\�}` :�\�5��r��e�\�\�\�\�OFN)���	\�y-�\�\�P�z�\����?�\�\��h<�E�=kגV\�P��Ϯ_\�ĢY�ba2\�\�(��S*\�_k�IN6�Z\n\�\�;\�mW^\�+<\��jTrkcǎU�(��F�Sx֭ \�Ve�͜9s\�\�\�Fa\�\�\�Q\'��*�~��\�7�\�z\�\�w_K\�\r�L�\"�-��F`i�W_}u�\�\�\Z��\�f͚Ւ\��\�Gm\�\�1��ոwР\na�$�)�\Z�t\���T��e1��|Uj\���\r��\�\"��\nմլ�&r\0�\�\�\�k�\�ᜎ\�gפ�\�JuJ��\�ڶ��9\�\��\�!Eao)�X�ݛ�GX�rM��\�\�I��\�&\�B�5j\�\��DcT����b)�Q�x�\�3\�j(n��D�	SB�)4K��\�2��\�\�\�8ݠ���\��N\�UG\"YQV��s\r9\'�๠4E!X���u.���\�Y0\�\�\nHf\��DMΉJ`cT�\�\\�?��\�\��\�XzH:��\�1$l�F\�\�ڊ\'6!��@cQHtH\�\�XF\�u�>�h\��UD<<���7\�Yh%\�R:F]�=\�ؑVŝ1c��\�\��\�e?�$L�>}G�\���\�`x\�w%J�ٍ�7/^�Z\�C\�8\�@0I]\"MD��D!�lOk\�\�\�\�U+�b\�Ò$j�\�	��(\�\�\�D\r�-\�(��Y�BH\�\�;\�\'�\�\�5e�ZE�|\�;��6\�\�&ս�\�o=j�\"\�~g�\�\�\��\�\�6\�M\��te\�\�7dHu3�&*�s\��\�\�>\��x\�b�)rk�Y\'\��\'�hɰ��\�\n\�E�?�0\�A\�\�w�Q�\�2\�Wd\�3_w\�u\�\�\�~�\�&\��\�z���~z��]X�\�\�\�.Z1|-Q�ٍ��g&O>\�l<\��LҌ<r�j\�&��\�}A)R\�q\�P\�j&���>\�_\��\�;�ĝ\�[/�O\�p晑\�4\�\��c�\r�v�\�\�.�\�\"x�-��Jدz2�V3)ȮPLǺn\�hS\�GtC\"]j\�u�\�\��\��\\`3��y�V�\�\�j\�ⷂp/�\�\�xE\\x\�O�\�\�ʲx#�|N\"\�\�.��?~|\�ȑ#\�ʽ��ȉjWU\�*	�DG\"����\�\�eF^RA�=\rP�̽\�^{-z�\�Q\�1!\�\�4\��\�H\�\�5@]J�@�&�.9\�l\�\�\�a&\���X$i�E\nԹ�߾��\�5\'\�4j<��Cý\�S끂F\�T�*d��IG�\�E0\� �:[A\�CT\�\�7\�\��]\��\�\�f�awA{	\�ʷj\�R�/��\�}��p\�\��\���\�7+�t�O~\�H��\�֪E3K\�-ё\�n\�,,�9s[n���SP�j\�ʪB�\"�E�$9 CU�$T6cT0\�Eb\�֪�j\�\�h%	\�\�\�\�Z\�%R\�l\�Y��,gsQ�\Z\�S\�\n�W�\��ǫ\�/Z�T�T|ĒI.0	\�H\�^)ɮ\�䚌2>2�\�U��p=A	7�<yWA+.;�\�d\�V�� \�\�\�\�t\�\�K[�#�\�ؙxq�\�M�B�\�%]����\Z��EqJ.Hv@e\�ךD3\�D[1��L$\�m+L��3���?Uya\�\�q\�/\���!B\�G\�I\�B��昈�-�V�0\�7;t�\�P\�\�?E��3\�Ǯ~\�\�\�j��,2\�	<\�D\�;-��\�\�J�V\�.h\�7\�bV�%\�O=\�\�\�\�o|c\�ĉ}M�\�\��E�\��~1`��\�\��\\�GI�%:ٍ�\�=\�\�qq\��\nA��\"4;o��\�\�\�%.P�\"��Z�L`\"i�l��\nQ�^\�\'����\�%q�\�\�U\�K��z�<ݞm\�(�<��Q�&��\�\�ԭNBsn�K�\�{�\���Ua^\��\�q�Oaj	�;-���#ZA�\�\�3\�\�u\�5\�|اO�H��{�\�\��G�^A\�&wh\��sC�=9tp7���\�ǡ:�$\��\�\�U�@�\�R��\�f%�\�\�\"\��ʋ �`\�4(F�\�\�?e�I��nT��/��\�`)D\���\�b��\�d�t\�\r�vf\�\n\�B�Ե�`\�O��\�3��x޼��+\�V4	�\"gq ^\�\�d�\�\�pnۜ�\�,\�J-���+ZE���7o\�\�\�^{\�{\�w�X��O�+J\�\�C-9\�\�#j���\�J\�-ё\�n\\\�x%�H�j�\�\�\�\�0\�\rvC\�\��Q\"5>�x݅A��_5��H%\n /�\�۲\�2�rG~EYS�)L�P)W\���\�s:h\�jB�Lr\�l�l�7�\�t9ul��>yĈ�\�FM\�z\�KW�p}|i�����еۮ�ʩ�ϥ;�#7���Tǌ3�r{\"\\K\�\Z4h\��m*7��JI�%:ٍ]	\�\�\�m��pnP(\�d)F]<T�	f�%�\���\�\�\�l�)\�(֗Ok�]��ԥH�T̿&\�T\��\�;\�\�\�15x\�\r\�P)Ƨ{�w\�mi=\\�_\n\� ]q�\�m�X`\n<v��e�\�c�\�\�\�cAE\�\�\�zK\�q�\"ZA�u\�ԩ˩R��	$Z�M���\\��01�7�&��G,I��\�%J�ٍ]	/͞��\�AM���\�L�I\�\�U\�W���֤l�\ZF��\Z\�2MC}a\\ԫ聴�ۂ?\�*���WeWX�\�@�j\�\�g\�&\��\�Ij�y&\Z�䙉9\�\�G\�*£\���\�\�\��\��\�%����\�\�%\\\�a^xaѻw\��a߾}^\�1\�.�e\�+?S�pe�Q�P�Q�W4�Um\�\�V�W\�_�D#\�n\�j@V�Ґ.�k(�\�<\�\�ҴB\�B�\rP��@uR\�,1�Ԩv\�\�[o�d{J�0���\�e P\�d\�\�*T#\�@�\�4�gkBM�k��<3�\��ܠ�\�I\0u�\�\Z�>\�\n��p\�\�\r,�(�\��:t\�\���z\�\�}\�\�ԯ\\\�w�|Vzp\�\�\�m�\�6�z�%\�EvcW�\�\�2Ӥ\�\"T\�\�7�ĈN�+#@�m~o\�˄XeC�Ԫ\�I/��z\�\�ןqF\\>�:U\��\�)^\�T*\�Vh���D\�,\�.<�\�b\�\�\�0a\'KL\��-�{n��`]���^���\�\�(\�]�\�\�U\�\�C�»�9\�VD6cڄ	}\��~\n\�\�ԏ�:\"�D .a�\�5>�,�Gƌ���\�\���\�z\�E\��Mt�(\\U�DB i5}�\�N�㎨R{.)�(�\�\�v�1�\"�|�XcWX\�\�m���H�\r!.w�3J\�-Q��nB е\�~�\�l�;�C�\�z\�)0�篪\�5#�ɵ;��6&!TZ� (d\�q��\�\�\n�\n\� \�\�#GF\�V\�w`\�OF[\�1L�I�`Q�m	2\�$8���JU�+J\�-Q��n[$;-%>\�\�q\�L\�\�*Ֆ��ĩ<c_X���\���	&\�\�\n&�1\�\���\�*,~.k�\�X	�� f���twEI�%J\�I�������h\�Ǐ7U��̞:��\�4e�\nCyq�ȴ�%|i�u�6\�$�R�:\�wB\�L�Y�b\��\�\��\�{\�!\\�Y�\0�1U�\�\�q#G�`o��\�\�)��\��m����9o\�>-ZԒ�	���f�\ZWn{�\�5�<ZA��Zɢ�JX{0����\� �.��QLnѲ�&s\�E{V��DuJ{ i&��QT�)�ٍ�\�Ϙ���\�-/u��\�1�&ǦN��\�&ժ$K�= �\�D�u*d\�\�R��\Z7�M\�/\�W\�\�*n�5ٍ�3(Ε��3�L9)\�\�z�Ɓ(������\�\�x�֍ZSPZ\n%J���\�,ք䄎DI�%J��[��Pn�%\�\�$��[�DI�%:	%\�(Qn�NBI�%J��[��p\�QG\�\�͕=��]�k\n�K�h5$tH��n\�\�%J�	\�n,Q�D��F\��\�\�`m*Z\0\0\0\0IEND�B`�'),(2,'logobueno',_binary '�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\�\0\0`\0\0\0�@�\0\0\0 cHRM\0\0z%\0\0��\0\0��\0\0�\�\0\0u0\0\0\�`\0\0:�\0\0o�_\�F\0\0\0	pHYs\0\0\0\0\0��\0\0\'gIDATx^\�\�?�.YV\�\�y\r\���\�h\�\���0�F��N0\��=� \n�� �bf:\�DԁɄL|\�M=̅��w\�s׽��\��>�w\�����U�WU=]\�]\�<\����\0\0\��l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\���_�\��\�\�g�\0PS6\�\�\0�f�\0P�k\�%\�0\��״]�g�\0�5׬�\�:\0<g�\0�5פ�|�\�\�W_}�zq�N\�\�l\0�\�\Z\�\��\�\�o��\�@P�6f\���6>D\�\\�\r�\\.�\�_�\�㷿�k�����k_�cWd�\0�\�|S4\�o~\�\��\��\�\�\�cWb�\0p+\�p\��\�w�5\�R\\�3\�\�c�\0p\�hS4h׼KL�\�\� \0\�\�5\�\�\�q;L�\�l\0\�rM5\�T�k\�S�b<��\\C\rs�\�\�0\�|\�`\r\�D\�ګp\�;\�\r�\Z�y�[����o2Ŏ˳A\0X\�5ΰ\�U�S\�4s\\�\r�R�Y�%O��\��\�\�6\0Gc�\0��k��\�T��\�q56\0K�\�\�U[`�Wa�\0��k��\��\�1k�\�u��\�\� \0,\�\Zb�}?|\�\�)v\�6�g6\0K�f�\\c\�\�\�)v\�F�G6`\��.s&n{Cˇ\�\�X�C1��@ol�4wҟK\�utn\��ͱ\�\�u[��\� �a\�D�����ܶ��j�c\�U�n/\�\��t��q\�\�~�m��-p�+\�f�6\�C\�ľ%\�(ܶ$\�4{4wz]�؛\rxΝ\�kѱ{\�!\�\�P۔�\�\����l�s\�d��ď�\�\�l�GL\�ׯ>y|\�\�\�\�bJ\�?\�\��f�\�\�\�\�\����}m+\�\�7\�i\�8\�;���aO\���׳�?5\��Gi=\Zێ-j�\�zwwg_ۊc\�}r\��l�{\��\�d_���D3�e\�\\\���7�\�t��\�\�\�\�q6\�9wO1\����2w\�SZKO\\�\�m\�\�\�\�\�;\�;y��mn\�\0\�8�SѮ\�\�\�\��h\�\�\r��;y�[\���\�6rWg\�⡶�L\�/@+6\�C\�\�\�L����T��1\��Kmk\�9>�o�l�\�N\�a\�n\�\�\Z��/�\�;��\��h�x\�\�n�\ZGj䮶\��m;��apۜt�\� \0ϝ�\�VS\�Gh䮦t��tu�\���\r\�N\�a\�+О��%��*<M=����\�s\'\�t\�\�\�ToS��u\�x��iu\�\��s\'\�\�n��\�(k]Cܲ[;\�\�\�\�\�za�\0ƹw\�\����Y��ڢ\�-���\���s\'\�T>\�\�\�1\�\�\�!�ݒ�75u��h\�W�F/\�1t�c����-\� �i\�D���]=�ȉ)\�WuѬ�\�ǿKn�\�6�wS�$C\�}\�\�Ls\'\�+\�\�!��\�ꃕ����l�<\�\�|f1k\r\�5�+�\��\�}�(k�ȕ���9l�<\�d|&ѠB\\u_\��5��\�\�k\�\�i\�h\�\�\�N½�&W\�y�=�K���S6���}U6\�h\�s��\�b�\�\�ъ\r�ǝ|\�\�\�\�t\�|ɭ�h\�[\\�\�{(\� �y\�I�%\ZwK��\�\�K3\�\��l�<\�ğ\r6\Z@���z4߼J[rr/�\�i\�u\�\�w\�k��F�\�6t}\��Ls\'\�\'iwMY\�	\���L4\�\�F3�c\�r�\�-��\�A�Ls\'ٴ\�\�?�c}4\�j^}\�\�\�m\��>ĵ\� �i\�\�\�ٝ�\�\�\�\�\����}M�m\�K\�X\�c\�\�\���\�_>��\�\�7��\�\�\�\�\�\�\�\���\�A\0\�܉5Ecp\'\�\'\�;��Z\�ė��\�\�\�\�[O\r�Eի\�\�\�\�\�{J\��\�e�\0ƹkr\'\�\�6q�+�\�c\�N}\�\�C~\��\�I\\�\r\�N�!��;!�E\�V4\�r�z\�㵵�V�\�I\\�\r\�N�a\�~�R4\�\�\�m�W\�jlZ]ߓ�&0ΝT\�֍�&��#L�;e\�Jߓ�&0̝P\�\�O6\�\�os�\�sU֮\�}�k�A\0\�\�	5�\�-h\�\�E/�\�Q��S| ,\�W��\�5\� �a\�\Zj4Z��:\��\�\�wGk\���p\�a�\0���j�1UK_���|�\�\�\�\�\�0�\r\�N�!�$v\'\�[\�\�\�\�\�34p�ѱ�\r\�N�a믗��<z�;\��\�;�򃈣\�G\\�\r\�N��&���?�V\�mQ�^l�s��\���\�\�\0[)�!�\�\�\�%`�\0��\�8	G\�ݪ�\�ć�\��w��ٰ�\rx\�N�sl\�\�i\�\�\�\Z8\�\�X\��o\�h0�L\�\�\�?T6\�\Z\�!�6\�4z\�\�&�l�wB]c\��r��{��\��\�\�M�M��\'��\rxϝX\�Xs\�H�\r�\���<�c\���l�\�N�K,�\Z/O\�\�\�+\�\�\�4p\�.G\���A\0�;\�.���_\�J\\�:KL�c6�s\'\��\�\�K\�d>\�\�M�l\��gj\�\���m��\�!6�s\'ܐM6N\�C\�|\�=\��\�\�՚��8\���%\�n(�l4��*-��\�?��M<\�\�^?#m\�.\�\�m�\�9`�\r\�\�I75���\�>x\�jM�\�\r�\�P�\r\�܉7,i8�\�\�\�\�5�\�N�^\�/c��\�p\r��\�\�\�?�\�w\�m��\�5`๓oX\�ģa\�\�\�\�\�T>��\�~��1\�\�r��+\�mǐ��\�\�6:�^\�A\0�;��\ZS�\�\�k49�s\��϶�SO�}�s\� \0ϝ�C\�&\�^?�r\�\��\�1���A\0�;	�\Z���\�ego\�|�-\� \0ϝ�C�&�\�~�������\�{X\��\�N�j\�\����M.�\�\\\�QŶE\�m�j�>ְA\0O\�\�wH\\9G�r\'\��\�<��3\�l\r��\�5F\�g�Z6`Y/\�\�\�\�Fp��t\Z8\r۲A\0\�x�i\�5ͼ|�ٽ~T\�W�\�x� �m��ǀ[\� �ۛxXzU~֫\�\�\�\�fh\�ؓ\rx\�N\�k\�m\�9\�|�{\�\�W�b�\\\�Q\���7\�!wr�kN\�*�j>\�\�j�M4p`{6\�C\���k��\�\�Y�]\�\�\�\��=\r��A\0r\'\�\�w\�T\�i\�0w\�g4p\Z8ڰA\0Ϲ�t�{\�\�k\�c\�\�g|j��Pr�����\�\���\�<\�N\�A�2�!k3�/�:\�}\�\�C	\r�\�<\�N\��5\�8\�G<L5�l�g�~\�%��^\� �\�\�\�:\�r�M.\�s��\�g�Ph\�\�\rxϝ�íl\�z\�p\�z\�\�ʙ�1��Z�A\0﹓v�\�j��\nw�\�d+�\�}�\0-\� �\�܉;\�r�M\�W\�e�;K/\��\��5\�ĝ�\�-\��sGoz\��\�3| 	\�\�}�\0{�A\0\�\r����\��c\��Q�\�A6\Z8�\��+s\'m\'zZs5�\�\�G\0,\�d�\�H\�\� pU_��\�\�\�Wۓ�\'��S\���\�?z3F\�wu�o\�\�\�\�\���޾��� ���\�-�\�\�~�\�\�=��gߵ\�W\��؛\rW\�\��_|p\�\ry\�U�S\�xQ��G㻻���\�*\�Ǿ�ۿ�����\�\�\�=\��^z`��U��\�\\1�<\�4�m�� Xy�\�\�\�\�CyS\�}\�\��+s\'\�%��\�xy\�x\�\�\0��\��\��\�\��+s\'\�\��\Z\�Q��Y~�_aÙ\� peT4j\�@\��x9�>�m�\�G\\p66\\�;��hq/ؽV\Zkt\�Hj>ض��\�q\��\�\rS\��\0\�\��+s\'\��\r,\�N5\�\�5\�ؖܮ9\�\�&fh\�8+�ʝؓ6\��\�f>\�\�W6\�#LK�\�\�cLz\�ϙ9	�^\0����r\'\�04�W�\�U^�{\�j5�\ZZgOrێP���z\�\�p6\\�;��-�B�\�\�s\� m\Z����A\��\�	>�M�/U6\�z�<�^~��\�8\"�ȝ\�\�\�W\�Gh\�G�F/om�\�c�\rW\�N\�j\�+Ѳ�oy����N�\��qE6��;�ٺіSս5\�#N�G\�4p\\�\rg\�N\�CbJy\�f\�s?\�4:�\�\�l83w��#�L�h��\�?\�4:\r��\�܉~��R���\���rv\�\�\�\��)z\�3�A\�\n\�	�[�׳\�\�ď4�\��o\�=����纥�g\�\�ӏ4�N��A\�\n\�\���\�\�و\�.��r\Z�\�?\�u\���\� p���\�v\�R4\�p\�\�v\�9c\�\�\�<��A\�\�\\H\�\\�qL5\�5M���v��T6\�x\�\�\�\���A\�\�\\H\�@��p\�4��[\�k>\0l��ػ�!��z|���A\�\�\\#n�;bzU�f*���\��f���1z\\���A\�\�\\3H?�\�\�\�\�\�?h*1�W�\�\\�\�\�sdc��\�\'v�-=<<�QNQ\�\�abl�[����^}\�\��.\�q�\��3s\r!DC��twwg�\�-ʫ\���߯2Fil;rV\�և\�j\�+�}\�\��_<�=��U\� pV\�Jk��\�(��\�뭔u\��\�\�\�\�\�%=���\� pV�)��w\�r/��{򥨋�c�����j^�g�\���ؽ\�Q����A\��\\c5�Z/\�\�\�\�l�L�G\��\�S\�Xxb��ٸƐj5��q\����\�,k\�6X��\��\��s6��k�\�Ux\��\�n�\�l@\�\�s\���\�\� p&�A�\Z?7Z6\�\�?�\r���\�h\���l8\�$B�[6��xȟy\�\Z8�=\�\�5��\���6\� \�\�*�\�a��Y�F��nl\�W�\�nࡗ��\���zl8\�(\�VͶ��s\r��`{\�C\�A\�\\�qe\Z\�Ѹ4W�\�w�\�\�\�z\�|2>\�k�\�f�7\0\�\� pt�Y�h�\�`��\�2�^^i\��]\�T~��\�\�-h\�@}6�k��?�\�.bk�]�\�zk凊[>�܊�a������\��\�e\�[3\r\�K\�,e\�\�\�CE~�m�3\0\�\� pd�i\�زᬹw\�\�Ux|@\�m\�\�CE\�1z�\0�g��Q���\�S\�\�S\�K�\�{�\n�Q\�^*\�}9D��\�\� pD�i��+\�l~K�\�{�\n/��\��JY��f�/\0��A\��\\\�HcW\�k�\�s�=\\�\�=+0��=^\0ng��Ѹ����\�\�)\�\�׽\�\�޿��Ӎ\�\�`6�kiNc^2���=\\�\��0O���A\�H\\\�Hs[^MFSr���i\��pP[~�\�\�*�ـ�\� p$�y$\�|��S\�{6MUN\�~�m\�}p=N\0�g��Q�摖L/gS��\�\'�\��߶9\�U�-M\�\�\�\�\���޾6W\�D\�vn1Ɛ;>\�ľz\�\�\�\�\�(\�qP�\rG\�\ZHXs�\�DS�����\�c\�K�bw��\�\�\�\�\�\�\�\���\�\�b�!9\�S\�\�\�%=F\0\�A\��y�\�<\�UNO\��\�k��S���ѹ\�\��޹\�\�\\��\�j;�uٸ\�|8\�R9�~\��R\�\�C\�8�\��޹�n�:-���I�_�j\�4��>\�zM9�>D���l\�k i�F[6\�-\�{�\���\�3n��\�h\����&���_\r3�\�[\�w�S��\�.X��\�0D��6l\�k �\�\�iK\�p\�\�\�\��^�&�\\:�=�ѹ\�\���&�\�|�\�4:_\'�g�@o\\I��[KL�c�@o\\Iq\�\�\Z\�\�1�`�\r=qM$�\�*��n��\�տ�\��~l\�k$�\�sK\�p\�m\�\�d��\� \�\�D\�Yf\�\�g^��\r=pM$]a\Z�\��\�q8\�\�H\�W\�\�H{�\�؟\r{q\�C�\�*�l�-\�it\�lh\�5�!-\\+{~�,>��W\�\�Zr�c\��^^	��e\�>8pl6�\��Ɛhng�\�}\�_\'\�gU�\�A�6\�0�ğuM\�b\�r;�`)jq\�bș��\�p+�\�\ZŘ3_}�\�A6�`-�\�Ę�_}�=d\��\���\� p+\��LM)?<<<\�\�\�\�׶R{�h\�_��\�\�\�WWm\�n;ʫ�!z\�\��5~\�\��1L�\�\�9OeGS�����m�\�y\r<\�U\�\�\�\�d��R�)L�\�\�y\�&\�z����\rs��0\��eH\�\r<\�qp6�qM`��?u�\�n\�\�\�Ї\�\�p68�\�\�$\Z�k4g�w\�ـ\�A�\�N�s\�T\�U\�{�\�n\�1^9��\��\�\� �\�\���\�b\�4p\0�\� \�\�\��\�K\�@[7p�\01D�5�c�A �������+7\�P>�\�\�\�b�\�$:p-6����\�yI�g�{�44p\�zlp\r ]\�;\�St�<\Z�˫�\\�\r\�\�\\H4\�\��q\�oh\��u\� �\�5�\��/n\�J�\�\���X\Z8pm6�\�rM M���+\�?\�\���h\�\0l\�\�\ZAr�\�*\�J;��s_\��\�[h\�\0�\r\�\\3\�4\\39;\���=��\r@�A\\�k\�S\�:u\�s\�\�\���l\�\�B\�\�{\�{q8d\�\�h\�\0�\r\�\\SHWh\�Ѽ\��ޡ�7�\�\�\�p~6�\�r\�!���\�v\�=n\�\�^~>f\0��!z,��\r\�\\sq%W�gi\�-\�궗\�h\�\0�\� �\�5�R4��b�s��M;\Z�N��\�>�D=�NG�!�\�A\\�kS��gs�\�g��q���e�i�x��֔�!p\�\��\�u�f��9F�k��l\�\�0cٲ\�g�Oe#+\�X&�/\�T�.\�ڸC\�E��\r\�\�\\\�\�(���M\'D3�\��\�\�\�\�\�\�\�t��_}\��꫏\�k*?8d\�/\�\�\�\�\�xo_ۊ#\��\�G��\�A\\�k)�M\�|R4����w�]6�h�yEM~m�j\�/ޭ#u6\�on��\�QC9F\�;\�\�;\�pm6���ajcZ#\ZX)*_s\�]l�ۿC\��\r�����\�1O\���:D�\0�k&%\Z�r1�\�\�\�=&\0P�A ������u�{KѼ�>�\�\0�\r\�5f\��]׼�.\�˒ׂ\0b�@\�5\Z\'\�\�rU�$\�\�\�\�t\���k8C�\�\�\�L�\'\�\�\00\�\�5�1q%\ZM\�\�\r=�q\�Uw\��\0s\� 0\�5�9�\�\�Cp��o\�� j���?b\�u.ݷ\0��\rS\\SZ\"�z4�l\�4\��!\�f�εS\�\�K\0X\��9\\�\�B��j�&Z�Ư4G�\�K1NruԠ�\0na���Y\�9\�g\0�\�p\�\�\�t�\0�\�l��khW��\0j�A`+�ɝ�n7\0�`�@-��n\0\�\���\\�\�\�	\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?\0\0��A\0\0\�?l\���\�c-:\�Rn�{\�\Z�\�M�ۊ�%in/\\��i\r[qcmA\�i\�մ�7\���9\�zz��/\�\�Y�ְ�\r\�\�6�{��^h�\�\�&\�m\�Ւ4wO�����[�\�פ\�\�\�ƯA\�݂�Z\��|��\�9\�zZ\�z������[\�Z��u\�BkM.7in+����{pu\�A\�Zí�%�gKn����ܺ{�\�q\�\�Jk\�߃ֵ�\rn\�ۚ\�4\�-\��7�ܤ���Z�\�\�jڋֶ�[\���[�1ZӚ\�p\�\�\�\�\�z��q\�\�Ek[\��\�\n݃\�5\�-\��7�ܤ���Z�\�\�\�ַٓ�[ߞ���ܺ\���-\�\�\�#�[�ez��;n�=i}K\�\�-\\�{\��Ƹ\�{�\�&��4�WK\�\�V\\-{\�\Z\�r\�\�ֹ�[\�޴\�%\��z�u+�L��v\�ָٛ�\r�\�ۛ\�8\�-\��7�ܤ���Z�\�\�\�\�\�9�[OO�޹ܺ&���[���\�\�\�\�+��\�\�{�u+�L�\�%lp\rW؈/§�~�_\�\'?�\�\�\�B\���\�9\�-�4�\'�ޤ���Z�\�\�\�j(i~\�\�6$ͭō]\��)n\�\�\�\��\��\�ᣏ>��[\�\���\����\�\��\��\�q,]\�n=Is[q�ͫ��4�7v\�ܣ���\�\�q��\�\�\�z\�x�?\�q\�\��1n���=q\�&\�m\�Ւ4�6WC\�\�#p\�4�6WC\�\�)n\�e4n�쭢�Ǉ�C\���.;ŭ#in+����[scͫ���4\�Hlp)�S\��?\��k4\\��-h\�}\�\�jI�[��!h\��\�H�ۂ�#i\��l\�\�\�\�-W\�sŇ�O\�F��\�֑4�WK\�ܭ�1�\�\�\�\�M�{$6��\�!\�-��M�Ϻ]-Iskr\�\'\�=�Is[pu$\�\�-�t\�\�S\�1�\�\��.3\�-�4�WK\�ܭ�1�\�\�\�\�\r�w468�\�!��:�q\�]��\�Y��%inMn���G\�#in+���y�[�\�\���q��g4�[>in+����[sc\�ۚ3i\�\�\�\�\\n���\��M�Ϻ]-Iskr\�\'\�=�Is[q�$\�Un��^\�Cgn�\�\�y�/\�<�\�q\�&\�m\�Ւ4wkn̠y[sc&\�=\Z�\�\�B\�)\�M�Ϻ]-Iskr\�\'\�=�Is[q�$\�Un���N���O���\�\��!n٤���Z�\�n͍4okn̤�Gc�s���b\Z\�-SM�Ϻ]-A\�js5$\�=�Is[q�$\�-��M�WK\�ܭ�1�\�m͍�4\�hlp�3\�j2��h\�}\�\�j	�ׂ�#h\��\�H�ۊ�%in\�姽�\�\�\�\'\�mmA\�e�\�\�j	�W�7h^\rnܠyGc�S܎(|ᖩ�&\�gݮ��y-�:�\�\�\�mC\�\�V\\-IsK.?\�S\�n�V^�W�\�����\�?\�-�4�WKм\ZܸA\�jp\�&\�=�\�vB�_P{xx��[nK9F\�&�\�_>~��\�\�Ӛ\�]\�\�V\\-A\�Zpu$\�\�ۆ����Z�\�\\~��\�\"\�\��翥\�mmh�\�ul\�\�\�s\�\�ul����y5�q�\�\�P�\�\�\�\rN)7\\|\���?t\�\�R��\�A�\�\��gZ{Isks5$\�m\�\�\�\�1\�e{\�jN�ۊ�%in\�\�l\�{z]\�fM�<�,]ǖ\�\�\�\�\�\�\r�WK�\�GI�\�\rNq�Vө\��\�t�\�ے�7\�-�4�6WC\�\�V\\-�iMk�\�&\�m\�Ւ4�\�\�\�ٚ���-�:�\�\�\�\�\r�W��%�\�V68\�\�M|C:\��|I\�kqc\'\�m\�մ�k	������Z�\�)�L��o\�Ր4�7vм�\��{кֲ�)���h\�\�\�u�4Kn<�\�\��յ�m������Z�\�)�L��oǍ�t�Z\�\�A\�js5\�Ek[\���Bޢ�oHǛí�Z\�\\}{\�ڦ�u$\�m�Ց4W�e\�U��˫Mk�ɍ4�W\�^��%lp�+\�-���t�9\�z\��5\�\�պ�k�[>in����\�-��\�\�]NmZCm���y-�z\��u\�e�S\\o\�\�7�\�\�\�ֵ��G�\�ִ�!n٤���\Z�\�:n�D�O\�o�\�4o��ִ�9lp���/\�{\�-\�\�)7u����q\�\'\�\�ۆִ��r�F\�2CܲIskqc+]\�q\�%�x}:~���yg\�[\�2s\�\�7x��\�1n���Gᶥ�OܾJ�\�\�\��W�\�0\�-�\�gO\�2-��\�M\\\�m\�\�4\�\�\�>H�;\����{���q\�\'\�=\Z�M5\�x\�\���[.inpy5\��c\�\�\�\';�\�j\���\�TM\\\�ۃ�+h\�ٹ}�4w�\rNq\�Jk\�O�{dn�n�\�\�8��\�*�L\�\�\�\�jѱ��u���\0\�\�&nk�?\�-��䮥c\�\�\�4\�\n\�~H�;\���A{���q\�\'\�=#�\�Is��ۿIs�[&inpy5\�s�\��O?�\�\�2�\�L��+i��l\�\�1n�!�lO\\�A\��퇤�clp��WZ��|\�\�3r۝4\���4W�e�\���5s	���^~\�\�G\�r˴\"LM\�h��l\�\�)n�.\�Woм+p�!i\��\�\�\�>\�-�4\��\�v\'\�\�zn�&\�Un����\�mE\�Zí7\�u_|��\��-�4w��\�\�\�\�4\�\n\�~H�;\���A{���q\�\'\�=#�\�Is��ۿIs�[&inpy�\�\�\�ʍQx�\�W\�b\\�\�\�\�O���[�\�ez\�\��wn?$\�c�SܠA\�Zq�$\�\�O�{Fn��\�b=��\�*�L\�ܣpےZ\��\�^�\�}n�J�ٛ�1h\����4w�\rNq�\�k\�Ւ4w�[>i\��\�N��\�\��\r�\�\�\��ۖ\�\�V�<��\�\��\�\�2S\�:�\�\�֫t�=���\�]�\�A\�\�\�7pмV\\-IsǸ\�枑\�X\�\�ۤ��[.i\�)�i\�~\0&��1\�r㿣\�Nq\�H���[�\�e\�\�j�wvn$͝b�S\��A\�Zq�$\�\�O�{Fn��\�b9�_K�\�\�\��\�\�M3�\�\�^�-O�\�\�\�\�\�S\�\�;\�:\�p\�I�{�~�\�\��\�4\�\�\�\��4�\rNq\�k\�Ւ4w�[>i\��\�N�{$n{z�5q\�&\�=\Z�M\�\�y-�NKk�˭+i\�\�J�i\�\�4�7no�\�9lp�<h^+����c\�\�Is\�\�mw\�\�#q\�\��y�[6i\��\�\�\�9�[W\�ܭ���.ӊ�%h^\rn\�\�h\�s\�\�7xмV\\-IsǸ\�枑\�G⶧\'Z\��|\�ܣr۶\'�o	����[r\�)]�WGм\Zܸ=\�z\��)���y��Z�\�q\�\'\�=#�\�Is�\�mO/�\�)nIs�\�m_kZ\�\Zn�Is�\�\�T�Lm���y5�q{��.a�S\\A\�Zq�$\�\�O�{Fn��\��۞�i�s�u%\�=��-hk�u\'ͭ���t��\��A\�jp\�\�Mk\\\���b�\�\�jI�;F��\�\�/?��\�\�\�9*\���\��۞!\�1�E\�[­/i\�Y\�>5�?wc$ͭ�s�.S�;h^\r\�x-�?Ck��\rNqE\�k\�Ւ4w�.\�\�>[���\�\�/i\�R\�-iMk�u\'\�=#�ݷ�c�\�l�C\�W�[S9\�]�7nм\Z\�\�j�^ju\�m\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\0@�l\0\0\�\�\��y��T\0\0\0\0IEND�B`�'),(3,'lk',_binary '�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\�\0\0\0n\0\0\0����\0\0\0 cHRM\0\0z&\0\0��\0\0�\0\0\0�\�\0\0u0\0\0\�`\0\0:�\0\0p��Q<\0\0\0gAMA\0\0���a\0\0\0	pHYs\0\0\0\0\0��\0\0�IDATx^\�_lU\�\�\�\�}\�\�6DED�P��R�\nTDPAQJQ�hA[���hU�M�台AKaQL��@p\�P_$�\Zָ11\�n6�\�{�]\�\�3wΙ3s\�v~�\��eΙ93\�\���!� � �/�/\�\�͛\�-]�ԣ?	B:�\�\�{��S�z?���AH7bA \��@��3q\�m�91\�_|1�~�����\\�\Z\�9\�3*�\�\�3G��L?Cq�\�a\'\�t����pu���\�\�G\�͜9SrA\0RLB\� ��A1� bA *\�\��~}WW\�7&ںuk�\�f?v\�\�\�\ZwmI\�\�͛\���u\�\�w����;�}\�ل�7宋Sww\�W}}}\���b���\Zo̘1F�\�\�+=$��(\�\�?{mI\�\r7\�\��fx�\�\�\�c�4a\�\�W^9MI���cǎe��\�\�W_\�mڴ\�?C%�\�\�\�k\�Ds\�\�\�\�\�uҹdC%�׽o߾3f\�`�\�\�M7݄�\�2(\�}q\�\�\�\�t\�}\��\�`�x�MP�?\�۶m[E;�j\��\��\�\�k�e�\�ӓO>ۻ�b\�C=\�]~�\�\�p�\�˼w\�y\�5�\"G\�̀�W\\q������-[\�*\�\�Qm>Dx^q}�^z\�Lq���\Z\Z\Z�\�!\�f���cd\"<\�K�l\�\�\��\�5\�\\\�粒s碸\�l�Ǟ={\Z�L�_�o�Q��\'\�}\�Q�̓\�T___�\�U���>\�\�\'|�[ZZ\"�\�\�=\��Q�\�ͱ�l�e˖���/��R\r��cc0�͖ӦM˔��p:\�r\�-��\�̅\�\�\�쬪�bϫ�\�I�\�Mw\�\�7���բE�bO\�`0@e����b\�\�4n\�8\�\'�p~\�a0øsꄆ\0��Q<I5n>ڂ��\�j\�ĉb��̚5�\r\�\'\�YԞ����\�ܹt�)W�^]�\�\'\��..aa\�8\�\��\�\�ŋ[,\�T=m]zh�0-�\�ED�\�\�)�P8p`vuu5{.�\�\���v\�w81�˖8��\�cT�F�\�.��⢿��&hPi�ґo�/�p��pB�|�\�\�f\�\�/\�\'�|2��7�2��C\��Q7�\�\�\�\�#�]3\�\�%�\\R\�\��\�3�v\�\�(�P<\�\�3\�9\�5z\�ho\�ȑ�ߨWΙP1rd\'c�\���h*<\���c�.rl̀/)gQ\�z����NE\�8��K��뮻<���b\�ΝA\�-0\�E]��\r\�n8IZ1Ie\��\�\��)S~�}\�eÃ�\�E�i1)�\�M{{�I\�\���Ⓐ�+ (\�pq\�t뭷z�A�K�43 4)��\�����k�I/$�.v\�ر�N)�\�(\�\�\�\�\�\�\�\�˗/g\�\�	\�pV�\\iv�d�?�p��K�No��\�f\�T�\�{\�\�9\�+�dɒX\�;\�\0\�1\�\�O�\�QϴQ���ͺ\��U�\�l�f�̀q&&�\�\�|�\�c\��\�o\�\�iҤI\�\�gN!�\�`Ŋl\Z��\�f\�\Z�\�4\�qq\�&�W_}\�\n���-p3�8N��6l�r\�ԩ�\��w,\'d�MMM��y0�-Qw\�y\'�?�\�!\�W{˖-{Mr\�?�\�܌���\��?;r\�\�\n������;V\'�\�?t\�P\r���l\�\�\�q\�t\�(����L�\�0\Z�\��I0�J\�pәl---\�{�7�9\������\n�;�s���5\�tv3\�\�\�\���\�R\�DQ65\Z*\�ܜ$�ͩ\\\�tB�\\___�\�^\�\�脍Z\�NZ2\�\�\0\�R�3�K��n��vm:\�\�\�?�΅\�	�\�(�I0׫駅V�\�o)�\0�o\�>��z(1f��;\'\rf\0\�>��\�W\�͙~ꩧ2�~\\�B\�w/�0�٤��^\��tuu��\�E(�����ڨS/�q3\\@\�b|\�1��K��&O��\�P\�m�?bP%w�NhY�\�\��\�\�\�%N�Y�f���jY�jUV\'T�J�_mI�\0�\��ĥK\'|��P�\�8��\���gc\0EaO9̀�a�7���a:\�r\�\����\�g��\�J�>�h$\�\�d����@zQ\�Gn�80�\rܱ:��\�\�n\�W9\�\�\�\�\�&N\'UI�מ={~O�}Q�9�š:\�\�$\�H�\0�y�\�@C��lذ\�(\�q\�\�w�	�>\�4:��\�T[[����dӦM+q��x8\�\�(\�:ؘ��X.�\�]��\�&\�B\'*r\�g\�tr�̀6d.�:�\�n�\�\�(xIT�=L���rq鄶o\�ͬ�f�[X9�.\�\�ޟgZ�5��\��Թ\�-Z.3\�\�\��ӌ3~\�<\�w<���\�Ls\�wB\Z\�\006�;�+�N�\�w\�tn�ؒ�\�\�\�o\�\�5�b�&g\��\r-˖-�3��_����\�h�,\�*�Eh\�\��M6���x0\�\��\�c\�w^�\�\�KM�P��d\ZW�(p;=r#]\�\�\�\�\���6\�/��r\"7����\�t��\�)�*m\�k�f\�p饗z#F�(:��\�?�|\�了\���ŋ�~�tET�MJ\0x\�\�\�~B��\�&�&\�\�Y\�.&a�\�\r�i.\\���ǹo�\�֟����\�ŭ\�IQ\�Ф���\�\�_d\�k+ŉl\�@\�f�\�7\�fG+\�\�ݻ\�)�\�\�\���N\�jy���͞�c�tBd��5q�CkM\�\�D�槟~��(�X�z\�UG��Nx�)x(\�n�5��s�\n}A\�+\��\�i\�d3m\�\�\�\�>�\�F�5ӦM\�\�\�\�	M�\�\�ۍ�\�C\�p�Υ��\���\n\�\r�\\e4\�e��?�x�\�\�;�\�\��\�\�\�\���tL\�\�~:v\�\�Q\�\�\n\��\�P[[{ܤ\"��\n�h\�\�[#f8\�~��z�/\�3uug\�e����_L\�7g�&X�\�\�ʴE	BG_\�Z3���ơ87y\����~B�7\�x#���\�0�rtfw.�I�\�\�XpE�8�\n.]j\�`δ\�0oLϥ(�%3�\��:s	M�\�d\�E�f�W��\�����\�N@��S\��\�\r���DV�PLSq3\�H�lvbL��B�mqB̐#\�f@�K`%	\�A�Z΄3\�H��ֿ\�֩I*Ҷ�.b��6�霅$��F+:b��5�J���!W\�\n}$���\�\�H̐#�f0].�d36F̐#�f0Y�M�ꆝ��ƪ\�B\�^Tӕ\�9\�}O�fϞ\�\�X\�K��`\�8{Cn2w-�¤���w�e��F�\ng\�qJ�\n\�uV��+��0\����CfΜY� ?a�ƭ ��aֳ\�\n�ͧ�,XͯԒ���X8�\�(��d̀=|�\�\�p\nbӢ��[E?CQ\�>g)e\�\�\�\�{gc�e\\�\�\�R��R\�\�SX����\r\�p�ڌ�\��*l�M�����t�\�:�\�Ҁ�+�c\��,\�L3]\�\ns�΄3\�H�\�u7}�0Nݶw\���2\�\�s\�\�\'Ե(\n_\�9ReL1�7\�r\�-��p\�\�\'\�\�h�B��!Gj̀2�\��f��T�\0���C�]���c\rE�E̐#5f�r亅�t²�Z4eѹk\�Z�T1\�w9J1C�T�A%r�\�wߝy�\\b8\�ظ\�\�=\�K^BO?��o\Z\�9Rat�\�+\�%D\'�\")sǉM3+rC�\�A̐#f��x)L�9<1`����^�\�\�\�\��jkk\�p:azl9���D�a��\�\�\�\'\�Mԭ	k$p��\�_ao\�\�\�n�(�J\�9\�$��^�`�����Eh6\�\�\���xo\\��q\�\�\�޽{(x���@B\�#fB\� ��A1� bA \��@`�ifp՛f]\�|���\�-5n((�&a�3�\nO�����t]\�o�_k\�\�\�\��cc�\��pi|!0\Z_�>\�駟�;t\��\�pLV8V�\�w.-�S\�0\�\�Q�\�\�0�\�\�\�=�\\E|\��YX�����(\�5k\��{c\�\0aq_\�߶d\���СgA6�\�\\�t)\��Β�fX�jU&X\�\�\�k\�\Z�X����\�$7�3k\�\�{\�mۖY!c\�ܹ�\rB\n\��b!rA��C1��\0~ӟ}��ˮ]�~�?e�\�\�2��\�n[$f\"\�E΀\"\�2m�g��s\"�@��p:��A�fPE�fo�L�nooo?��\�K\�\�Ψ3\�\�?�쩢Uf�\�\�\�\�\�b!r\\�`����\�\�\�\�ϼ̈[\�\�ر�(�\�\�6n\�\�8q\���\�1f\�[�n]f	���Y\� D�+3\�^֑X���e��s\'k�&\�s\�=�\�P瀉p<�P\�г��ȉ\�YP���r�\�\��Y3`�hWW\�7\��\�ڵk\�)~b!r\\�/{\�\�\�\�\�\�ܜy��Ef\��\�\�Ԋ��ڑ5\�$�\�<AEX3��\�<lW�%\Z1����	�T����\�t��X�_\�+k\�̀^i\�PaOs\�h�\�\�\�\��G�\n�.r\�\�ی�\�W^U��\�%�\�΂�9\�- �V(�\����U\'�{D�	�Q\���3!fB\� Duu�3pîm(�\Z�\�V,[�\�cp�2\Z\�g(\�\�\����T\\N\�6\����3�B�I�@��3!fB\� ��Al��%^04��$餿�:M��l!��!C�\���i\0\0\0\0IEND�B`�'),(4,'mn',_binary '�PNG\r\n\Z\n\0\0\0\rIHDR\0\0\�\0\0`\0\0\0�@�\0\0\0sRGB\0�\�\�\0\0\0gAMA\0\0���a\0\0*bIDATx^\�\�O�%ɝ\�q��}Z�|\�ؠ�\�\�maP!<\�r��\�\�\�Y�i�\r�F�i5�G����\�+P\��\�\��ZOՍRT\�/3~���]|\�:\'3\"#2\�Ɉ\�{�\�}\�k_{\0\0\�!\�\0!\0��q\0\0E�\00(B\0�A\�\0\0�\0`P�8\0\0�\"\�\0!\0��q\0\0\�$\��\�\��~7?��2�(Ï2�(Ï2�(\�Oe4	qU�v���\�B~�\�G~�\�G~�\�2XN\0`P�8\0\0�\"\�\0!\0��q\0\0E�\00(B\0�A\�\0\0�\0`P�8\0\0�\"\�\0!\0��q\0\0E�\00(B\0�A\�\0\0�\0`P�8�\�}\�_�\�\�O~����\�����\�\�\�O�\�����u�8�C�\���O�\���\�w�����O\��\�{\�6\0l�8�\�,x\�\��\�D�N�8�Cx<�\�\�	r��\�\\I�\�Xb\�\�\0�R[]�%v�\�$\��\�\��~7?��2�(Ï2��ehi\�\nf��^~\�\�\�ˏ^��\�;}\�G~G�\�$\�U\�\�\�f~Ve�Q�e�y\�\�\�\�:�_�\�o��\�\�s?\�\�;��\�4\�W�韼�K�\�����\�9,�<Ѐ\�9��^\�\�\�\��<G3}�4g\��B@u�etw��\�x묜�\�qU�8��<\�\�\nyk[\�\�,�>�8�j<\�\�\nhk\�K\�!�\Z\�,�$`Yb\�\�\0��\�4����\�a��\�\0�\�\�\�=\�\�kXb\�E��\"\�F�\�Yxj\��\�Ȭ3!\�\�`�B3\�;�h��%v\\!`7���A�Y�EK\�[%v̀�[\�yx\�\��s\��KTwf\�!`7+�K\�K�.�kf\�!`�\�\�p-w[۵�u��Y9FC�\�E3X+��\�\�\�l]b\�\rv���\�\�\�\�s�.�k;k@Oq`\'\r\�a�6�Y�(\�f3\�\�r��\�\�\�[�\�\�ZE\0�q`��K��\�f\nt\����\�Y\�\�[��\�u\�\n\�	\�\��Y�\���[\��\�R����$\�\�W9zD�N\n\\k�\�+��Uf\�r!\�\�rt\�\\\�%\�\�Bph\�g{\ni\�X��]Or\�\�c9zC����I!1Ҭ<\�6\�6=*Y^\'\�\�BX�[.n�\�e\�\�\��\n;k�^�,�\�\�E�<O\��\���\�\�����Y�v���gEֿ��\�\�\�O�^~�\�[�fQ\�[�⨶Z;��]���\\\�\�\"ȏ>�V(\�\�2���*~�\�\�\�j�?\�\�K\�\�</\�wr\�~\�[\�\Z�_ߋw\�c\�6[�����\�wt��|5V\�:��\�ɽ\�x\�q\�F~G��r:�\"\�B�{k�%\nsm\�\�IɌ\�H�U�^j[S;ȁq`��\�\Z�c[6\�̭�Y\�,���qk�\�x�|\���2ra�\�mr�wV\�یo�\��\�\�fD� \�u�\�#ā�ܒ�\��4�-\�XV���m\�O�\�v��k \��\� �w�\�A\�Ì/��>[�y������\�C.�J_p�x�B\�93,T�U���\�\�<�sv\�\�zq��3�\��=\�H����r\���\�v3\�\�\�\�H�q\�#\��\�N����A~ƒ�\��ٖ\�S��\�\�\�\�qBp\���Y\��7ȏ\n�\�\�}A\�6\�\�EDf\�8\n!8r\�\�,\�zf�\nQ\�r�?Ѫ�xn$b*Ǫ\�lr}3\�\��\�!\�\r޵�U\�\�%��+���o\rW\n.\�J�\�C��\�:Z\"ā���\�\�)O��\�1���\�\�`�\�UV)p,B(��\�%\�x;,k+\�J/7�?����>�\�c�f\�\�ϫ\�\�B(���\��;3\�w4��n4���ןc\�\�=\�1Xmt\nbO?/a�5\��{\�Y(�����\�7V\n\��Jc�,!ā\rz�����6��\� n��/j?\�\�Q�6�\�l\\%˻\�B\�\�\�\�5\�	\��8�Q:�\�F\�ӬYa \n��b�u�W���\�9,}[\�U۩\�k����>�Bب�%u����ҥ\�G	\n�Z�s\�~��6\�a9�\�n�d\�\�\�q�\�\�H\��\ZЭA6��?��/��t�o���\�\�9zꗸ\�\�\�\�\��\�9�7\�\�w\�q`�t�Oi���[��9�\��P&�1S��\�֠\�<?\�\�[\�c!ā\r��5Vk�\�,P�#\�\�j9�\�Py%a��;k?��&!�x<�\�\���Y-�\�G~�2\�[*7��\�\��\�}ԗ�\��ǧ�_~\���[;�\�Q\�i=\�s��\�h\��\�v3?��2�(\�\�SFX\�^�`��J�ck�\�\�y�_����\�\�\�\�2{|NY\��\�\�~3��r:P(\�<\�\�f��!�uq�ms7^g\�\�,*\�\�p-�8P\�\ZP���\�V�x]\n\�x��v\�\�5\�{\�qB(�\�ր\Z\�~\��\'�\�\�8�N\�խmp-�8P �\�\��@�\�1\�\�%�w�sB�r\�)k�\�L�\�3\�\�y*�{�sB��^\�$ķS�\�}3\�\�;\�=�\�8�\n��I�o���\�FpQ�\�1Xj��1\�@����\�̈/\�h�:[\�=����\�!ā\�`\Z���]B\�O�6C�\�хY8Bp\�\r�-VB\�\'}��v��7��Fd	�p�8�B��f\�r\�3JB<o\�\�b\�X��#F�B�zip�=C\"\�ש\�C���Fp\�\�(r E�\�sI�Yo�0\'ė\�\��;ߐ,a�!<\�ZaN�\�fp\�2�ǉ�q�\�s/\r�{�x	\�w\�>\�\�Ի\�S�Q\r\�@�\�̨�\�f\� L���\�/p��\��\�\�Ǵ�et,!ā{�\�S[bB��4�G�-\��p�5�8�B��\�C�X�l�\�\�x<\�[�_�\�,n\�Y<=�%�/\� \��\Z3\�!~\�\�X�Xc�@c5\�S\��`晩[�]s\��\\\�?S�\�\�%Q\�[\�1BpZxCȮ�f�-��0��Z�\�\�\�\�५6�&Bp\�(p\�s\�𹶍\�\�B�J��4��\�*>�53ݴ�-Bp\�xL��=3����\�\�}�m\�\r��I�?����n~Ve�Q�\�Z[B\�Rr�\�ҁ}\���|\�㰨�\����o�oɞ��ڊ2|TF�W\�o���Y-�\�G~ke\�\n\�\�o0�>O�?�f\�ǒ\��\�\�1Zt\�{Vmfi+\�\�S,�N!P-{fPK\�\�י���>۱�\��\�f\�c�C�Ng��\��\�c�1�\�;\r9�+-@@�Nk!\�\�ų\0-nz0{�{~�LZ�;�BX��Xˡ�%\�q�i�q�6{�\�x\�\�\�\r\�!āk3\�T\�\�\�9q\�\�F\��Ψtl\n/n\�\�\"\��\�e��B_e\�\�\�K\�\�\�\�l\�|��\�\�\� \��5\�z\�\r\�8f[J\'�_#�Q!��������y���\���\�Ս�c\�!�Q!\�3۽Jg\�\�\�\��\�VJ|����\n�ZA.\� \�\�3=Wp�v\�\�Y\�UI�\�v\�>\��-{*tj��\'�T^��,~|LW\�\�?�\0�8�Q2X��\�7��]\�n3�,�^\�@F�<\�♩\�BL������3�5�\�@F�}G\�}\�\�|my|Ʒ�\�6�\�m\��\�@\�l�\�\'BX��u��Lr\Z\�k�y�\�\�,\��\�h�V\�n+x���]r!�Aƛ!�\�+BX� �\� \�k\�}\�\�|� #�\�3BX�\��;]J/\�3Ìu\�\�╅^b\�q`A\�y��YW<�>�\�\"ϞՉ�\�Vab8\�B�r���t�f\�q;\�\�\�\�y98\�D�-�ƳK˞\�\�a��^��x�\�\�{l�cƸq \�*\�\�y\�/\�[��b\�\�J|��\�\�\�q\��7�\r\�[f㡜\�_\0�7Ël\�ǒ\0�\�\�\�$\��\�\��~7?��2�(\�G�\�W/?yz�\�G\�\�K4\�\�\������\�R[��nDB[��#Ϋ�?���\����f�Z�/נe���&!��\�n7\�Z(Ï2\�\�\�\�\�\0\�֠\�@\�\�\�_Ƌ�!޲�\�sp�է\�\'\�wji}^�\�J�|\�\rנe���ӁgZ�n/m\�\�ò\�/E���p�\�wFnF<�}���>_�\�C<~n\�]y\��Y\�@�V����<j�ǿ�l\�� >�\�����8�\�k���!/��l%�ą\0\�q b\r\�1��\�\��Z\0� i�b[m\�\�c\�\�\�\�<p���\�YC�\��h.\�\�f٣�x�:1\�a�\"��H7W\0!<\�$\rf�})\�\�^�\n�8\�l/^F_�1\�\�\�Y9	\�\�e\0zD����eiY3\�x��?\�f�aƿ�Ϟ�c��)\�C\��W\0B��x\�\�Rs:J�\�m2Z�\�\nB�=k`��-���\���#/�\�n\�b��\"�12B���\�^z�=c!\�G]F\�\�eLߵ\���\�\�(DN\��n�=�C�\���Q�\�	p\\!�K)}[Yjm�T\�[�\�ue]u.	p~�3!\�q)ᥲ\n��a\�s��0e=^\�\�P�[�FE�\�R��x��i�\�\�\���h\�\�>ң��ǥ��)\�T\�y��\�i�����\�p䨝	p̊\�\�>O\�]^\�S����^\���\0\�\�q\\RIX\�y\�^^�\Zi��\�\�]k�Lq\\�B\�\Z�Kl]vA�u��\�e\��\�\�V=	p\�]�8.\�\�\\\�\�[���g\�!{^F/}���v�B�\�rr�Pp侷%ĵﰽ\���\�p\�\�G�J\\߷\�̊ǥ\�3\�%\�wזp�_�ߝ��\��\�\�uYR�\�8��ǥ���XK���tV�eɶ��\��V,q�r\�78��I�?����n~Ve�Q\�k�Y�\���Y�BB3C��\��~\��髗��\�V\�\����V}\�h��^~�ћ��j�\"p}�Q�\�Qe4	qU�v���\�B~�\�ZX\�^�@ku\�\r\��\�8��ª��k}\�բ�ҕ�\��\�j=\�\�\����\�`9�\���o�a{\�\�\�\�\�G�\�\�\�t\�QGl\�\n0B����֬\�\�@�>�\�#�z�8Ͽ�? \�1��g\�!�\�._\�\�K=b8�!�\�\�f\�-C-.�\�\0�_f\�%\�\��|��G�\�\"\�15\�,�U8\��y\��4\ra\�\�A	O�8��\�\�Κ�\�~vp\�m\�\�Wi�[�\0\�\Z!�iy¢ů��\��۠��\�J��U�g�8�u\�,<�f�\�g\�{�\�G�cJ���=3M�\�\�q}Ξ�\�@�8���\�lR;\�>\�o.q}�ϏB�\�\�NIh\�\n\��5\��G�\0;�>%}q\����qL\'T�f�����\�\�?{o\�\��>g\�lծ��p`BS\�\����^\�=\�\�qy�Q|S�\�eh�\�T<�\�\�\�v���a\�\���h\�MŞ����~\�J0BӈlI�|8���e\�^3\�\�̛\n\�K�B��\�FX_b[�-�\�\�,\\7(\�XϺ�m�C�u\�B`K���㷸K�\�{������n*\�\\C�\�\�Bn�aے%\�\�f\�\���)\�<ʐ^\��!�\�y�p\�f\�[�\�\�~{����*@�\�!\�14O�\�¹tI=�i�>?Z�	9+$վ�=��ng�\0�#\�1���\�@!�\�z�\�\�w{����2�\�Mth�ǰ<�po��٤B\��<�C\�ss\�Z��8c\�}��\0\�!\�1,\�,\�\�\�\�]R?34S\�\���(\�a��Y�<O\��\���\�𛱌��p	��\�\�\'O�g\�2�\�\�\��f����\�:Ζ���u��z�\�Go\�*yQpɌ\�n+�\�7SMB\\�\�n\�g�P�ߌe\�^�\�2S\�6\n�������\��7�j�U8��\�l\��\�\��\�՟S[\�\�2\�\�\ne�\�T\�\�N<#^�e7^�\�l\��\�\�\����\�=\��\�g�p�8�f\�K\�\�þ5\�Aז���T�P��+�\�\�}c\\!��\�3\�%{B$޿B2���C\�\�\�������\�\�\�jq\�3��֍B?F8:,�6I\�\�F�\�\��\'Hj=�U`*�4\�ey8,\�\�y\\�E|\�Du�\�\�\0�q�3�y)7��92,=\�.�\�\�\0WC�c�\�\�v38s\�\�\�\�r�B\�\�,\�\�<?k\��\�dֶ\0�A��{!Ė\�$,�XC��kq�-ь\�\�vt�/�ϼ���G�<��Yg\�\�}��\'~�\�!�ny\�\�\�%\�#\�3\�#�\�\��\���~\�\�\'�g]\�=\�׼\�!��(H<\�c���~\����\��q2�/�8�\�}�\�\�C�\���et�?�8N�\�Y\�,0�5L\� =rɚet`\\�8N�_¼fS8��WtS��e֕`t�8N�\�\�GjƟ	�g\�G�2xV@�~6��ǡ�/��n�.\�\�\��\�>\�wZ\�ת\�#\�q\�\�S��߈�\'y�\�sp`�8�ӌo\�\��̳o\��\��y\�G3\n\�-K\�2�\�#�m±�\�\�\�\'G\�	�6�8�\�޳Ͼ\�\�\�<�4T�#�\�خI�?����n~Ve�UƟ�ٷ6��\�ogh+�\�W/?yz�\�GM\�:�x\��\�{5Ce�Q�\�Qe4	qU�v���\�B~�\�г\�\������\����\�3\���\�\\��j�\�G<�_S\�|�sW(Ï2��*�\�tl�\���\�\nK\�A\Z�G7\���9\�(�\�޳dh?\��g4B��l@�8�B[~=�e\��\�Sg��߮�\"̆\�*\r\�֠_Ja�@�ʘ\�\���\Z!�E\�X��\�+�\�\�\���\�\�0B&o,Q8\\u�7J�\�\"0>B\�HC�\��\�ci�\�޾\�E6`�8\�\���^)ms\�\��-\�3~|N\�\��Ɂ�\��\rBo)��_y\�<����|\�\r\r\\!��xf\�W�\�b\�6\nR\�{�y��\�B�\�-\��#� \rγ\�\�\�%�R�q��\�*S�\�Z�|~每\�8?J̉\���tfr\�љ\�\�\rp}\�\���q�a@\�\�\�*4\�֌;�ř�o\�8�\'�\�q�\��\��ળ9\�Ƕ\�^�&��8^Ʌ��\�ӥs�癳o!�\�q��{�팟{>�\�;\�\�o!��q�\�\��#3�+��\�[w+֒��B�\\5\�u\\zƝ����cέ�\�p\�zq�����!\�LP3\�Y\�\\\�b\�n{	o)\r\����\�+�\����#�B[�.��ݠ�>V=-8p]�8\�X\n�{w�ϙ�rU\�e-�E�\�~\�\n��6Bo(Ԭ�B8*d��^�ֶqЇ�\�\��\�6\�>\�\\X\�z\rnQ�J\\ߵ\�\�:���\�\�x�\�\�\�g�P������RA\Z��Xa�w��O��\�w\�a�\�W/?yz�\�G\�g�p\�?�\����Cmhǒ\\�_\�\�݃2�(\�\�2���*~�\�\�\�j���2r!����Kˈ^a�\�\�kп\�o\��:��\�\�\����C\�\�qXǻd�b��W[Q�e�\�T\�\�x�\�\n��\�ڶ�,�?�?����\�j\�5\�\�\��k\"\�\��g�\�\rb�\�f)E�H\�x�\��,A^.\�ށE7U8\0!�\����|\�\�\�\�\�6�i\�n\�\0��I\�\�\r��\�LѦv)}q-�M\�\�XT\�Y#�\�\�\�[\�[\�Y��!�U�A.W\�\�\�A�7�\\!��-A.�Q*�ft\�\�Yw�\�Y>P��\�\� Rڇ�j\�PW\�\�:�-?&fa\�\r`+Bn\n\�=AS�+C�\�\�C��\�UT\�Z\�ӱ[u\0\0/B\�\�\�\�s�o�|����T��T��@\�V=ZQ}f\�\0\��86�9+�\n\�8�ݬ\��-q\�B�\�i\�Mxh�G���\�<�es\0-\�Ja�g\�W\rtf\�\0�D���+��s\�\0\�B�\�0!\�Û\�V(\�La-,�\�!�S)\�E�~T�֏�\�\�\�\���\�*_\�χ�^\nk@�q\0\0E�\00(B\0�A\�\0\0�\0`PMB�\�x<\�\�w\�Z(Ï2�(Ï2�(Ï2�TF�W\�o���Y-�\�G~�\�G~�\�G~*�\�t\0\0E�\00(B\0�A\�\0\0�\0`P�8\0\0�\"\�\0!\0��q\0\0E�\00(B\0�A\�\0\0�\0`P�8\0\0�\"\�\0!\0��q\0\0E�\00(B\0�A\�\0\0�\0`P�8\0\0�\"\�\0T�<O\��\���\�\�?\�\�?\�\�?�\�$\�U\�\�\�f~Ve�Q�e�Q�e�Q��\�`9\0�A\�\0\0�\0`P�8\0\0�\"\�\�\�\�{\��\�\�/�m��#:%Ŀ�\�o>}\�{\�{��~\�\�\������\�g\�hڿUv�\�֢N5��\��\�깵\�\�Nk\��xF�[}����\���z\�Y}�Ku�\�\�~W\�o�\�W�ߖ\�\�˘�\�\�����m\�\�Qǁ\�B<�Ⱥh���g\�e�:\�\�O/\�\�i�s\�\�rpZ��S\�\�\�C\�U�#Y}ZJז\�c\�~V}j:\�\�Z�\�u���y�U\�om߳\�1o\�q�i��\�*}����\�/i\��x:\'su<ʞ���\�E\���\�\�\�1\�>)�\�q\�\��\�\�@�?{p	4X\�K\�z\�#\�\�р\�\�El�x{\\ծ��U\�R�\\�ޱc��\�\�oo֎s\�\�1\�6a\�*\�{(U��)B��\\�\�\�^�-o�\�R#\�{�=\�\�[P�Y:{=\�֬�y:����W\�Y<�U\�T/+k\�\�ru:˖��\�p�1\��\�H!�t���x�}\�E�\��V}S�x=�:\�=\�m\�\�;\�QN\�ן\�i�\�kF\nq��m��i�U	\�\�/@�\�)B���B\\\�oա�\�(�Pr\�\�\�G��}X7*3��\�\�^�\Z\�{.@�4�\�\�\�w̪w\�\�V\�G�_�v�ꐪu.�*m�\�\�Q\ZH��U���\�Wתl9�J�v\�r\\%��۷>O۹%ϱ�m���\���U^\�\�f\�9>Q�Ye�Fb�B|\�]Z���mṉ��K\�B\\��\�\�ԞV}���x�.\�kߦ<�k\�Zt\�{\�T<\�\�\�9�9n\�Ԯ\�c\�\��}Xr�y\�u ��k9^X\�Ŭ\�e�q �+\�=wv��\�\�!\�ϻ(�\�\�t\�\�\�97F�ps\�hI�\��V7Vb����K\�Z�\�:&\�\r�\��͍�G��\�\�\�\�FI�\�b-C\�*/6\�8�\�\�2hyb\���c�k9pԖ\�ֳ\�\�ͪC,wS\�\���m\�ss\�Y\"\�\�f�ku-z2\�q��\�!�;\�;hB�_\�		k�^\�\�\�iߵ\�\�3�}�znN\�S/B�mVy�V!>\�8�\�\�F�#.@�a���K\�\�\�\�\�\�\�B\�xk}m}?vV�x\�7\�9L��\�*/vV��6�6��gɩ\�\�#\�	\�%�>U=�\�z\�[�\�\�P\�e�A\�#w\\�\� �B�mg��h\�@jS�[\r;�QqB|I\�\� \�\�\�Z�\�\�&\�vGɅ�\�\�!\�\�f�k\�2�W\�!>28�\�g^�Kr!~\�\�sn�1�n5S�\�;�zˍ����7\�Vy�3C��q��\�\�]|bm\�\�\�C�\��ЪG\�W9V�1\rjG\�g���\�\�\�:\�x,�\Z\�J�!n\�#\�\�Z�ʋ�*\�;�ϭ\�{W\�;9]|�\�\�\�~��\�\�\�h\�_|\�\�\�\��\�\�i\�Ĩ\�?�\�Ӈ~h~&q�ό\�\��\�\�X\�{l9�\�@*j#��\�����d�?JYu\�\�%�wT��\��0\�,��7\��:��\��U�\�R�\�1\�cIP;\�smU\�\�\�\�Vy�О-�<=߬��\�\�J����\�v�N5�����\Z@p�\�\�\�k	e�qu\�g�}\�\�\�i��\�\�*.\��i\����~zX\�\�Kl9�<W,\�[\�\�q�A{\�\�Q\�G]�?��\�ͺ{C��\�H\�\��k\�+��\�c�Ϋp��\�\�*7v��]lOX\�\�B{�\�\�t�lq��\�2\�q��Uq�Ǖ���밴\�X\Z>\�wZ�˴x�<�Kn`��A����^GQ_\�\\\�r����Qr��t\�\��\�\�u�\�\�\�aO\�\�õi�\�rMx\�8��ksQ��\�\�{f�b-;\�r\�\�ɩc��\�K�\�\r\��\�\�GK�s\�h!̭�.\�1ĭz\�q{[9\�u\�\�rmZe\�Zg��O��eH���\�oV$fm\�!^R:iD��y\�\�CpF\���U���^V}-���BȪGli`&\�\�=F���p}Ze.јץ�\�X\��^ǁ=\�.!�,׹=���\�Z\�\�\�\�z�^V}S���U����\�ocɍxG��Un\��\�ǁ!�l\�\�:gJ\�\�,\Z��ˋG\�����\�5\�M\�\�\�\�\'ď���Uv\��^ǁ-AN�?=\�E\'����\�\���\�\�\�=\�\�!^\�nkAL�\�\�G�X\�ǎq	\�sOa��?����#\�.��%5C�KoA\�[�\�t���\�Qk�\�R=�\�}�~��-m��r�$\�\�;2�ŪC\�\�FR\�C�Gֱ�JC\\��L�^\�.\�6�\�{\�\�\�^s��k�@��\�l\�;G\�\rD��RmfmwO�\�;ֶA\�!�sMe\�\�mͪG,מGR]j�9�\�g�!\�;�8ޓ��3�ީ?<7Vk\�6J�{��\\�\�\�r\r�V�b\�v�C\\\�\�Y7HV}b:g�\�f\���\�o�\�[\�g��x\�\�s\�\�u\�\01\�@=z�{��ܱ�}�\�\�=\\�V�bWq\�\�\�\���}s[!�l\��\�\"\���TtL�\'\�\�\�\��v#��\�nV\�km�>}�{F�\��\�&w��쫅\\[{\�\�\�4ĵO��\�\Zm��õ\�K8Zu�]%ĥ\�\�\�!ğ\�5��\�,r3\r\�v(Sĩ�C|\�\�òwU��\\x�\�SPc�V?\�Ʀ�\�\�c Zu�])\�s}�ӟ�\�\�\�B�?#\�	\�#\�γ\�B\\\�Ŗ�\�\�\��-\�\�p\�\�֖ /\���z\�\�?�я~dng!ğ\��J�8\�K�\�\\\�\��w��99#��z�<�S3\�%w��B?Y�:�U\�ؕB<w-�\Z\�:i��k��%�}Y\��8!^�\�\�j\�`m`/\r\�\�Z\�K�]s�[���#v\�y繱\�֩v���5w�\�\�־�f\�-v�\�\�\�/�Y۵�AŪG\�\�.�PqB|/Oh��dI��@��u)�{��p\�c��\�o��Q�ܪW\�*!�k�OXۥqB�%o@�\rd���x\�E\�_� \�!A\�u\�*\�E\�In����a�N�+��\�|�\�7�ano!ğ\�s���\�L%��oC�ϭ\�\�\�=\��m\���:N��k�kT��\�5��Y\�,)	ޖ!.:o(:޳\�ҪO�e�tΜ�d(\�\ZB�!>_��\�\�r����\�.\�\�\�v�˝{�(Z�x�%ȷ\�\0\�a\�%\�*\�gR��3B�?�\���5ĥ4���\��?*\�eK�kk_�X\��\�\�r�F�\�g\�\�}\�\�\�\\\�i\�\�\�\��-\���An�#ķ�g��3B�?�\�9\�E�U:�lM\����U�qQ�\�VyK�\nr�\�\�\�C|\�yF�?#\�	\�\�\�!\�\�{��3B\\��\�Un\�!�\�FQ���\�\�x�\�\�\�l_S(�e�\�\�O����?�:ɏl+\�`o�\�r�-o\�筨�O?�Ԭ\�\�?J�\�t\�\�q:\�k\�N\����v�\���\�+�\�q\�tO�[e\�Bٵ\�+k8㼲\�\�V[5	qu�\�v{g��B-C\\\�\�g���s�?���ς�!\�\�qĬ�7\'\�\�\�B8|�ᇛڪ$\�{\�->��\�_�\�W\�\�\���Vxq�[\�U\�O��E�\�\�s��X(�\�ye�-�\�`��p�����ڪ8\�5P���kI!n\�#fm�\�emԾ\�z�kǚ�\�Qt�X\�r$��\�Y.�|��/u|q0\�\�\Z��\�~�~\nZ�i\�\�#�\�\���UV�E�2\�8�*\nq\0\��׿�\�W>�\��b\�\�\�\'0\"B\0�A\�\0\0�\0`P�8\0\0�\"\�\0!\0��q\0\0E�\00(B\0�A\�\0\0�\0`H_{����\�)O��\0\0\0\0IEND�B`�');
/*!40000 ALTER TABLE `publicidad` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscribe`
--

DROP TABLE IF EXISTS `suscribe`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suscribe` (
  `IdEvento` int(11) NOT NULL AUTO_INCREMENT,
  `EmailSuscripto` varchar(30) NOT NULL,
  PRIMARY KEY (`IdEvento`,`EmailSuscripto`),
  KEY `EmailSuscripto` (`EmailSuscripto`),
  CONSTRAINT `suscribe_ibfk_1` FOREIGN KEY (`IdEvento`) REFERENCES `evento` (`IdEvento`),
  CONSTRAINT `suscribe_ibfk_2` FOREIGN KEY (`EmailSuscripto`) REFERENCES `usuario` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscribe`
--

LOCK TABLES `suscribe` WRITE;
/*!40000 ALTER TABLE `suscribe` DISABLE KEYS */;
/*!40000 ALTER TABLE `suscribe` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscripcion`
--

DROP TABLE IF EXISTS `suscripcion`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suscripcion` (
  `IdSuscripcion` int(11) NOT NULL AUTO_INCREMENT,
  `FechaInicio` date DEFAULT NULL,
  `FechaFin` date DEFAULT NULL,
  `NumeroTarjeta` varchar(30) DEFAULT NULL,
  `EmailSuscripto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`IdSuscripcion`),
  KEY `EmailSuscripto` (`EmailSuscripto`),
  KEY `NumeroTarjeta` (`NumeroTarjeta`),
  CONSTRAINT `suscripcion_ibfk_2` FOREIGN KEY (`EmailSuscripto`) REFERENCES `suscripto` (`EmailSuscripto`),
  CONSTRAINT `suscripcion_ibfk_3` FOREIGN KEY (`NumeroTarjeta`) REFERENCES `tarjetacredito` (`NumeroTarjeta`)
) ENGINE=InnoDB AUTO_INCREMENT=25 DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscripcion`
--

LOCK TABLES `suscripcion` WRITE;
/*!40000 ALTER TABLE `suscripcion` DISABLE KEYS */;
INSERT INTO `suscripcion` VALUES (22,'2022-10-05','2022-11-05','5464536464536456','a@d.com'),(24,'2022-10-05','2022-11-05','5647564756475646','agustineves17@gmail.com');
/*!40000 ALTER TABLE `suscripcion` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `suscripto`
--

DROP TABLE IF EXISTS `suscripto`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `suscripto` (
  `EmailSuscripto` varchar(30) NOT NULL,
  PRIMARY KEY (`EmailSuscripto`),
  CONSTRAINT `suscripto_ibfk_1` FOREIGN KEY (`EmailSuscripto`) REFERENCES `usuario` (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `suscripto`
--

LOCK TABLES `suscripto` WRITE;
/*!40000 ALTER TABLE `suscripto` DISABLE KEYS */;
INSERT INTO `suscripto` VALUES ('a@d.com'),('agustineves17@gmail.com');
/*!40000 ALTER TABLE `suscripto` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `tarjetacredito`
--

DROP TABLE IF EXISTS `tarjetacredito`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `tarjetacredito` (
  `NumeroTarjeta` varchar(30) NOT NULL,
  `Vencimiento` varchar(50) DEFAULT NULL,
  `Tipo` varchar(20) DEFAULT NULL,
  `EmailSuscripto` varchar(50) DEFAULT NULL,
  PRIMARY KEY (`NumeroTarjeta`),
  KEY `EmailSuscripto` (`EmailSuscripto`),
  CONSTRAINT `tarjetacredito_ibfk_1` FOREIGN KEY (`EmailSuscripto`) REFERENCES `suscripto` (`EmailSuscripto`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `tarjetacredito`
--

LOCK TABLES `tarjetacredito` WRITE;
/*!40000 ALTER TABLE `tarjetacredito` DISABLE KEYS */;
INSERT INTO `tarjetacredito` VALUES ('5464536464536456','05/24','Mastercard','a@d.com'),('5647564756475646','12/24','Mastercard','agustineves17@gmail.com');
/*!40000 ALTER TABLE `tarjetacredito` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `usuario`
--

DROP TABLE IF EXISTS `usuario`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `usuario` (
  `Email` varchar(30) NOT NULL,
  `Nickname` varchar(20) DEFAULT NULL,
  `Contrasenia` varchar(15) DEFAULT NULL,
  `Tipo` enum('U-Suscrito','U-NoSuscrito','Admin') DEFAULT 'U-NoSuscrito',
  `fechaRegistro` date DEFAULT NULL,
  PRIMARY KEY (`Email`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `usuario`
--

LOCK TABLES `usuario` WRITE;
/*!40000 ALTER TABLE `usuario` DISABLE KEYS */;
INSERT INTO `usuario` VALUES ('a@d.com','d','a','U-Suscrito','2022-05-22'),('a@e.com','e','a','U-NoSuscrito','2022-05-22'),('a@f.com','f','a','Admin','2022-05-22'),('a@g.com','g','a','U-NoSuscrito','2022-05-22'),('agustineves17@gmail.com','agus','a','U-Suscrito','2022-10-05'),('root@hotmail.com','root','root','Admin',NULL);
/*!40000 ALTER TABLE `usuario` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `utiliza`
--

DROP TABLE IF EXISTS `utiliza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `utiliza` (
  `EmailSuscripto` varchar(30) NOT NULL,
  `NumeroTarjeta` varchar(30) NOT NULL,
  PRIMARY KEY (`EmailSuscripto`,`NumeroTarjeta`),
  KEY `NumeroTarjeta` (`NumeroTarjeta`),
  CONSTRAINT `utiliza_ibfk_1` FOREIGN KEY (`EmailSuscripto`) REFERENCES `usuario` (`Email`),
  CONSTRAINT `utiliza_ibfk_2` FOREIGN KEY (`NumeroTarjeta`) REFERENCES `tarjetacredito` (`NumeroTarjeta`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `utiliza`
--

LOCK TABLES `utiliza` WRITE;
/*!40000 ALTER TABLE `utiliza` DISABLE KEYS */;
INSERT INTO `utiliza` VALUES ('a@d.com','5464536464536456'),('agustineves17@gmail.com','5647564756475646');
/*!40000 ALTER TABLE `utiliza` ENABLE KEYS */;
UNLOCK TABLES;

--
-- Table structure for table `visualiza`
--

DROP TABLE IF EXISTS `visualiza`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `visualiza` (
  `EmailSuscripto` varchar(30) NOT NULL,
  `EmailNoSuscripto` varchar(30) NOT NULL,
  `IdEvento` int(11) NOT NULL AUTO_INCREMENT,
  PRIMARY KEY (`EmailSuscripto`,`EmailNoSuscripto`,`IdEvento`),
  KEY `EmailNoSuscripto` (`EmailNoSuscripto`),
  KEY `IdEvento` (`IdEvento`),
  CONSTRAINT `visualiza_ibfk_1` FOREIGN KEY (`EmailSuscripto`) REFERENCES `usuario` (`Email`),
  CONSTRAINT `visualiza_ibfk_2` FOREIGN KEY (`EmailNoSuscripto`) REFERENCES `usuario` (`Email`),
  CONSTRAINT `visualiza_ibfk_3` FOREIGN KEY (`IdEvento`) REFERENCES `evento` (`IdEvento`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `visualiza`
--

LOCK TABLES `visualiza` WRITE;
/*!40000 ALTER TABLE `visualiza` DISABLE KEYS */;
/*!40000 ALTER TABLE `visualiza` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2022-10-06 22:22:48
