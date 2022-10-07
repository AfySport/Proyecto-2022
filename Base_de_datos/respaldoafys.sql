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
INSERT INTO `publicidad` VALUES (1,'logo_empresa',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\\\0\0\0o\0\0\0 x›\0\0\0 cHRM\0\0z%\0\0€ƒ\0\0ùÿ\0\0€\é\0\0u0\0\0\ê`\0\0:˜\0\0o’_\ÅF\0\0\0	pHYs\0\0\0\0\0šœ\0\0L\ìIDATx^\í\İ	¸]U™&`•.¬\êÆ®.ºšF»Š\î¶Qq`d2CP&C$\È \ó<GF™IbHBaJHÂ˜™)	CB2@,\ÅRÑ²v¯w™•œœ¬ssÎ¹\ç\ŞÜ›\ì\õ<ß“\Ü}\÷\ÙÓ¹û[\ßú\Öÿÿ\ë#EQ”(Q¢D‰N@vc‰%J”h=²K”(Q¢D\ë‘\İX¢D«q\Â	\'½{\÷.\Î>û\ì\ğc~Ÿ%Vwd7–(\Ñj|\ç;\ß)\ö\Úk¯\âû\ßÿ~ø1¿O‰«;²K”h5J\Â-Q¢$\Ü„’pK”(	·D\'¡$\Ü%J\Â-\ÑI(	·D‰\á^~\ì±Å•\ÇW<=i\ÒYiÛ¢E‹Ö¯Ü§YÌš5k\Û\Ü\öF\ñ\ô\ÓO\ï•\Û\Ş(fÏ½yn{£xù\å—\×\Ím_•X°`Á¹\í\õ`\Ö\ã\÷¾¸OŸ\âú³\Î*8±onŸF±\Ç{´„p\çÌ™³in{£x\å•W\Ö\Émo¯¿şúÚ¹\í\â\Å_\Ü0·½Q<\÷\Üs=r\ÛÅ³\Ï>Û’\ãÌ›7o\ã\Ü\öF\ñ\Úk¯µ\ä9Ã«¯¾Ú’\ï\îÜ¹\r\İ\Û\nn/\Ùÿ\í¿‡|\éK\Å\Ô	Z\ò²•\è>|\á…\ÅÁ›nZl\ñŸşS±\ËÿüŸ\ÅÜ™3[\ÒI~\ë[\ß*n‰5Ù\ÏL|\ÖnŸúT±\÷§?]\\\ÆaÓŠû”X½0ı\ÑG;m\ß}‹\íÿş\ï‹\Í>ú\Ñb\×@¶\ã†Ÿ’Û·”–B‰K\÷›nZpı™g†ÿşu\ãz\÷.ú†\ä‡\Õ\î™P\Ì~\òÉƒ\Ó\ïK¬^¸\ì˜cŠş\áŠ-ÿ\æoŠ¯†?‰ş§6\ç\÷m%\á–(Q¡p=zøq»\îZ\Ü|\ñ\ÅÅ‚0Œ\ô\ï\ñ=z{l°A±ù\Ç>V\ô\Şr\Ë\å|\İ\İ“G±ÿFE’M\Ø\ö?ÿ\çb|•mBI¸%JTY\nsŸ~z¯³¿ı\í\â¤=\ö(f>şx\ñÂ´iÅ .(zm¶Y±\ãº\ë;4\ô’KŠŸ¶Ğ¼.\ÑùxmÁ‚\r\Î9è ¥$»ùZkE+a¿\Ï|¦¸ı\ê«?\Ì}¦½(	·D‰\Z\îCw\ß=\ÂyÇµ\×~\ğ\ÂÔ©\Å\óO>Y\Üv\ÕU\Åw·Úªø\æÿú_‘Ÿ|\ğÁ+rŸ-Ñµ\ñ\ğ¨Q\Ãü\â‹­\Ö^»8\à\óŸ/\Ú~û\â\Ô}\ö)†\\tQ\ñV‹fns(	·D‰\Z„›`\Ò\äªN(F^ıÏ¦M˜ j¡8?¼8_[g¨v/ø\îw‹\'Ç½\âÅ‹»\\XT‰\åÁ&ú\á\ÑG\Ûü\İ\ßE_\ŞHf\Æc™Û·#\Ğ]\÷\á‡>eĞ A\ZÁw\Ü1¶•!K\Í\àè—»¶®ˆ\áW.\\¸p:\Ï.·O[¸\ó\Î;\Ç\æAg`fx†:#w]9<xÎ¸q\ã.NŸ_\á€9Œ¿\í¶\É×~z1üŠ+\naC&\Ó(]³\ÙB‡¼¼“GŒ¸\ç\å\ÅH–h-\Æ\ÜtÓ‚#¶Û®\Øú\ã/¾³\Ùf\ÅM}Eû\å\÷\í(t\Â\íÙ³g\ñ\å/¹!lF~^¬\Ü\ñ:\ß\r\â\'wm]\ßø\Æ7Š±A¨!Ü“N:)»O[\Øv\Ûm‹«;\ÈúZüı~\õ«_\Í^W\Ûl³Mq\Ë-·LKŸ_á€µ\ğz\è‘¼\å–bÀ¹\ç\ÆÄˆ>\á¦\Åj&»\Ë.\Å\ÙX\ÜÕ¯\ß¹c¬.x6¨ \îĞ¹<ÿ\Ä½u»¬·^•œ¾›\çy¤`+µüä¥—²	-a4\Ó\òø\ë\î@¸\'N\ì›{i\êÁ!‡R´*À¿tG\Âuİ…Q\Öşû\ïŸİ¯-\ì¼\ó\ÎE«E\ê…Q„k\Ï]O-\ô\ê\Õ+|t\Ù1–;`-\Ì\n/\î«\á\æş\ô\á‡&ÌŠ‡ï¾»8rû\í—n‚\Ø\Í\ï}\íkE¯\Í7/\Î€#ú\÷oaEv\Ù\Ì)S:m[\rq¦6m\ày\ç—ydqÅ±\Ç×rJŒÊ¸\õ\òË‹i+É¨Z0cÆ\éÿl–wß½xüşûûU\î\ÓU°x\îÜ…v}\'\ô\Ä[®½vq\èW¾RŒº\ñFm\ñ—ÿ\÷\â¥Ù³‹;¯½6†ş…\íoØ¿\ò\ó\ó}¶G«\'Ïº\á~ø\áÙ—¦l±\Å\ÅÈ‘#G\ä\Ûè®„ıO|ı\ë_\Ï\î\ÛN=\õ\Ô\ğ\ñŸEG@\æ\æ\÷¾\÷½b³0B\Ì]K_	\ï\İıU±\ÜA\Û\ÕC\å†ÿˆ\÷™É“‹}ş\ßÿ+vşÿc)\á~\ã¿ÿ\÷\Â\Ğu¯ÿ\ó\â\Ë~ø\Ö[\Ç¿z#Û\Şq\Çb\Ğ~P\Ü7dÈœ†QyüV\ãÇ‹­?\ñ\Î;Çš\ìiq\Ù\ÑGG’\Ü\÷3Ÿ‰…I#ª|§p\Í\"0L !bi­¹\ãQ‹H\Èdâ›l‰Ì¿?\nşFI\í\rDºù\İ7\Ü\ğ3»\İù/1\Ä\ë„\İv+¦_ü\á\ßş-\ì\ò\×\öÿ\ñÅ¯~\ñ‹bü\í·: Î˜_1Y\Z~\Å\"je\Ù\Õ	W\Z\ë–[n™}q\ê\ÅQG•?~G£;®‘A3\ï\ëîŠ¿Ù\Äe—]­£\Üu\Ô\ÂYg‰¢]ş8\Ëı°2x™ŸJ\ğ\Ã?ş±ø\óŸşT\å[\ô\Üh£¨fe¦!\Ümş\öoc\0½şû;\íT¾\Í6‘\àø½Hn\ç0¼E—„\Ş\â­˜h@\Z\â‡\÷\İp\ÃH\öÔ¨	>aO®\É5P\áA\í/Ï™S\å[\\HÀ\õ\Ù\çÜƒ¶=\Ú¯‡^\í¡ Z\Ä\';\ãlûwW&uì¾‘¶°¹›BGRy+?>v€¾Ÿ\ëÒ¹…\ï¬şX\Şù\ÉO\Ân\Ë\Z\Òı\ã\ï_ü\ì7\"!\ë8(ı{ƒ€uTH7\ìš=_£\è\ê„{\Ì1\Çd_šF€\0ªMg¡;.\Üt\ÓM¾\Ş\Ë\Üşm\á°\Ã+ZU¡&MštÖ{\î™=-\ì¸¯ú8°Â†j\Ì{\î¹•\Ãm.\Ï=ü\ğ)\÷\ß\Ã\ğT\ÈØ…¡wÅ Ã‘ah\ï7ÿéŸ¢×›2˜\0±m±\ÖZq¶\Ü\Îì§jW\ÛÜ L(X\äl¾\ö‰ODO¹\Ç\'?3\ä¨<“E\ß\rjÛ„ß”û\î+^™7¯˜?}z\ñÁû\ï\Ç!\ö¿}\ğA\ñ\ìC-	—\êÔ®N\òM\Çs\İ{ÿ\ßÿ\É\ë7¿úUTŒ¿|\ç\â†3\Ï,¶ÿ¯ÿ5\ŞÏ·¿\ğ…\â‡A\åtVœ²0®\'|\ğŠ¿ù\Íb\ÛĞ™x¾µ`\Ü\ğ\á\Ñşy\ì\Ş{‹c\Âø¥\áº\Æ\ßv[\ñ\æ+¯D²M\Íÿ}—¿ø\éOc§Ï€°9{¾\ö +\îÔ©S{6\ó²\çpJèˆ«\ß\è\î„GqDvÿ¶@u^„B\õ±Z‰\ó‚id¢j)\ï6\ä03³ƒ\nZ\Z\Ú \rxì­·Nù\Í{\ïEÂšû\Ì3\ÅugœQÌ:µ¸\í\Ê+‹\Ó\÷\Û/\Ú\nHQU’\í\×9]Ô§OTU¢`û0´\\y¾¶°8¨\Ï@\"¨Rq:v<ş\Ç>¶T]#\Ë\Ş[l½\ËY?\îz\ã9©ºÿ\óŸ‹_¿ûn±pÖ¬Bœ\ñû\á>~¼hQ¼\Ê\ã!\ê>\÷¹\âÆ³\Ï.^_¸p9¢J\íƒ\ßü†—[\ô;\õ\ÔXwb\×\õ×aW\ì‰\çyä¸°K\ö>Z‰3{\ö,¶\\\â§\ï:9ß‡\ö‹·\ß.f>\öXa²\ók®)®>\ñD\ÖA\ñ\È\è\ÑÅ‚3bG\ó\áş\÷\Õ<‡\Ğ\ñœrWÿş\ï…³\çj]™p\Ï9çœ†¼¹¶@Ù¬Š\êq«\á\n¹\Úw\ß}£\÷™û\\-|3VU‘«Æˆ0\Ê\Ûn»\í²\ç­\ßE\õq²s0\ÌD²\ég¡`×|r\ñ\Û_ÿ:*$/9OĞ„\ÌÍ—\\R\Ü\ò\Ã†Sˆ‘\Ù\ò{\r\çy»Ğ·W¯\è«*’#\÷µù\ó7\ä\'…È°§4\n\öüC\nÖŒ;bu<„ˆ\Üvÿ\ç.¾µ\ñ\Æ1ˆ\ß~·_}u1sÊ”¨`ÿ\ğ»ß…C‘XX\î\â¹s‹\ß¢ümPªAa\Ç\")Di\Ìû°]Ÿ‰¦z\Úü@`lD{Mx.ˆZ\È[\ã\â\Ğs?z¼ ¬\Û=‹-²`B\è *;©«?>ªl\õtr¢H´ß‡{\â\âw¢ŒşÑŠw~ü\ã\â\Õ_Œ\äû\äƒ\ïş\ë¿¿ş\Å/\â\÷¸¤}ä¾›on©\Ç\ŞU	W‰\Î\İv\Û-û\â4‹\ãşúü³\ç\ë(¬„&Ğ¶Üû\\-l¾ù\æ\Å\Éá«>V{\ñ\Â/lÊ²È³LşMic\î#»1\é \ÒzMDùyÎ´i=É„;\îˆC\ô\ßı\ö·E\Ø\ÕŞ¿¾ùf\ôFG\\w]$D†l\r\ÓÍ¾ŸT…\Ê75ŒOû\ğ‚\Õm`üSC}\Ş/r\İ+\ëEA \êK\Âù‡^zi´3\Şı\Ù\Ï\Âe-k¿ş\å/#™.œ93^á¿†„^|\î¹\"V1\ğü\ó£­Ác6i\æZª˜¤X\'\İuW¼¯z…h\ÍI\'Eè”¾\õ…/DU\î\ï¸=ŠÁ¡¡$E~„eŸw:#\ß}C†\Ä\ç\ÇŞ\Ì\à\r_\ö€ \Ô\Ü\Ë\É{\îYü>¨Wu\ëy\'2ıUx.:¤—_x¡x;o \ğø,\ÆV,zşùh9˜Ps¾\ÊQM{\ÑU	\×.V2\÷\ò4‹wĞ’?_Gau!\\8\ğÀ³Ÿk9lØ°¥\ñ®­À5\×\\\óa\î\\µ€ø¯#ü\ê\ãT\"»±„xQ®)­WL§Ÿ‡\\xaTx¹=<jT1\÷\é§\ã°\İË¾S Ş§I\'…R‚Šj\Ód¡:E¶	_Š\é\Ú\÷\à/})zÀg}\ë[‡lÿ\õ\Â\éW\Ş\ŞX¼8-\ò—%g\âˆb}\èî»‹øA\rR\×HJÚ²û@\Æ\×7#(\äGÇŒ‰Ê¯Ñ†°f„¡üˆşı£§KA‹\Ò\è\î+\İ\'Ëƒ\Ú7©:­±\Èmş\ô\é;.‰Y\áÙ‹„P`HZµ\Æ™\ãˆB by¶\Èr§ü\Çø¬§Mœm’~Au\÷‡\ëI‘\n\ïEkF\ñ3ï¼Š)h\×ù¶²jXW%\\×•{yÚ‹•½x­F3„k’¹u6£À\'x¢w\î>À\Äc£)²s\Ü\çŸ¾%‹\n<ù\ä“\ï\Z\Ä^\î\\µ {e\ÖFvc%f=\õ\ÔÁ3+VXP+W\ì&\Õ\ô\Ôø\ñQm™\ñ\ç\ß>^|/\ña˜j\Æ\ğz¥F7[k­\âˆ]v‰\n3µŸ¼ürq\Ô;\Ä!¼¡ü·ÿ\å_\â\ìøC‡F¥ŒĞ‘8¥V\Ù\æ\Òn¤!\ä;\òú\ë£\êdA «	\Ø\õ“ŸŒ*Q¡Ê†t\î¡\òzkµ·\Şz«x¿\ê\Z5\çı\×\ğ;\äf\ÂJ$Àz\õ*N	Ä£À»Jl&\÷>\ï\õ°Ğ¹~\'e\ZQ\'°)(Z‚\nDƒ¸\Ï\êOüc<ŸkUa\ë\ğ<¯d)š„u csOG!¼h\Ş;w\Ş3Ï°ƒ–[Aƒ\õ!í—­\ğd‹|\è}\Âuµ‚p[9#MÁl¿ı\öÙ—§^l²\É&Å¿„¿\Û\ê\íµf©\ÛB{V¨$\ÜÏ‡\ÑZ\åµ\äÀ\'\İ/«C\Ô\ÅøLø\Û\Èı®ˆO6\ÌN?×³\òË±\Ç»\Â5{\Î_£\İ\ê\í	2\Ğn¸\áC\İ\ì1Á™g™=G%6\İt\Ób\ã7ÿ\ç\óÖ£°³+\ñÚ¢E\ë:t†`ø´mN \àQ¼D=:N\ÂP†¯\å\éÿHSˆ\ÑşŸıl$„»} ‰û\ï¼3ª«Ô¨\\\Ùi&š\Ä\è\òù‹+k.\\\ò¿ú\Z\Â6iVA!\óê” œÇ†{uĞ\ö\Ó@Ì¿ù\Ío–üT»!q\ÖÇ\Ã0ê¦ \'\ŞqG´6ø\áÇ†\ç´s…\n®vŸ \È\Ù:\'>82G\Z\Û\àAƒŠ¯„\Î\ë{;\ï®F\Ñ»«_¿¿\Â\Ïl \Íg„\ç™•A6-\÷ı·j\ÈdH+·U\Ë\ÙPBI\õK\Ô(@pMÂ©;wG Â¥«S‰V-­\Õ,£e2¬\òšWF¸\ğ\í ¨t¹cÖ‹{\ï½w@=>2\Âı\Â¾ÿ¯ƒX\\GM™\ì\Æj„a\ç:Š”W\Ö\Ã*63¨ CUj\ôş›o.)\ïıü\ç\ÑR0\ãO¹\nQ2\Ä=cÿı‹\ß\â\ã§ş\Û_t\òˆ‘Œ\î¸@|^~ÀÛ¯¿\ß\ŞF\É	= vv«<«B|\ê[a8-´mU¶ÿø\Ë_¢2}ÿ\İw‹Wƒrg\Ü;xp\Ñÿ\ô\Óc=bÄš\"=xÀÂ»x\Ì:*ª\Õ(!5\÷\ë{ş\ïÿ\'C§·#^#6‰3–’G\ÄT¼\çn\âlşŒ;\Ê*Y\áo ½\èj–\Â}\÷\İ7 \Ñ!c¸şŸ\×;\ÔEh^ş\ê\óv\Zµ\ê!\ÜU\ÃH:w\ímµK8hFc¹c\×\Â\îÃ¤ı\æU\ì\ÆÂ‹½®L«\ÊP\'A\òB‹¼\ÄÂ»\çH˜^`^lŞ¥\á/Ÿ¹PyB©|\ÎPw¿ ‚©M\öÁ_\Â\ï\nşiH×„\Ş\÷‚ªE\\¬\rQ\Â\ÉDT\Ôc¬ª\æù™\ô{#©\öøgV\ğ4\ÑG\ÔF Xí›šg\'şX\ì\ğ‡v<Œ›ÁHD\'É® |)^¥ıBûˆ8k¾²ÿ·\n]p\r\ñ	ƒ‚ùı Aƒi$\ÛHl\ï\èÑ£‡\ç\Î\ßj¬„k¡\Ïf<v\é¨Q£šz\î?\ïCî˜µ ¥û\Â/\Í¯\ZÙµ \Ğ\Ş\ì»v?\óú\ÆC¬®ü|ª•\Ò5!D•™1\'Z™ZŠT‡ß±LUªZ¿¯Œm¦\İÕ¿!\ñb·O~2†xIŒxv\ò\ä¨$¿;5Ê•-ÂS\Ì\'z\æYT>[\Ï\Í6\Ï^\Z³08M²Ä\Ù\á{r<\ñ\ÈÔ¿\ß	¤¸E/,\n/\Ú\Âw»²ú +î£>zœkÉ½@µñ­¯¾ú\ê\Ú\Ûm·\İ;¹\ß\ç@mF*\Õ\ç\ï¬„:¬\Ü\õ·©p®F\í°—^ziıFCÒŒb\ZY¹7»±\Z\á‘jP\\T‘$?‹mMv€`ú\ó=´80ƒÅ…\Êp2¦|ş\ö\Û\ñEO\í¡‘#‹=\Â\ĞWÖ™D\n\ñ¼©U\î\×L\óyCñ¯†¡¸Yû‘A\İ	\ïJ^gwi†ù?{\óÍ¥„‚\Ä\ä\ğ\ìN\ßÿh×°’E“\Z\ë \ç\ç>\Ã\Üd\Â9	2	\'bšy\ì¼^n\Â\Í\ï\Õ\ÆV\æYM\n¦8¡€­\n\r\ëJ„+/¾u+\Ï?\í—}\ö¢‹.:?·O-\ì²\Ë.Å˜1c†T_C«±º.\\şfs\÷\Ğ|¿\×_}ChŠ\Ó\äU\Â	û5X1»±\Z\Òo…\ñk®\ñ¯00d”—l-d«½\ô\ÂQMRXWˆU)\æsÑ¬YqHk\ö\Ş\n\ö‘f\â\Çq5ÿJLhV…:>BB\ô\Òz‘O#-©?ª1ÿª&j*\ÔsI\×Á‘À`¢\ÑJ»o¥Z\Ù\Ø\Â\Í<ßƒ6\İ4ªbM\'\éû1\Ñ)\î–5°Y¬\ÖÄ³?ŸŸ\ç\ÆZk\İ\n_·«®l&ª$\÷\å\àÅ½ùæ›ŸMŸû\í·\×\r\Ã\Èrû\æ`\ÈÙ·\ê¯Î„+\Â\á€\È\ŞG[›[¯ú¼\í¶\Û&7¢n=?\Ó\Õ\ÇY²AT‚Š[\ég\nW\\&%d\â\Ë\ğs\Î\ÓO\Ç\á­\Ğ#1§T*o\ĞP\Ö\Ë\Î3¥š¼\È\ÈBÌ§Ï¨c ÿŸ\Ï(\Î\ö™‡Š^¥øU\ÄB-\Ö6\ÒL~‰6@N)FU2@£\r\ñ \É\0\Ô$\âGh©CX:5’ Hİ£NE\Ø\×\ä˜I\Ê\ÊQk½\èĞ˜‰\'®Yz³N\ä™I“bd„\ÏK\Ğx\à–[\â\óšx\çq²NG\Ç\óıe8\ö•\Ö\í*„\ë\ÅÊ½@µ°\Ç{Ó§O?¤\ò§œr\Ê\å¹}kA½\×iÓ¦\õ¬<F«±:.0\àF«u¢D\ÕÇª†\è‚F-&dÎš\Ê¯-d7&„—qÀ\ã³o\ïº\ë^Ÿ¦7_}5¦\ò\Ê\æ\ò\"{yy‡j*P–&\ÂúO7.† I£Õ*–f\È\Ë\÷\õ{J™\ó\Ò#„F[Rg\Òk©[„+Ôª™†œ$>\ğ=%JP\ô«j’M\'\æz\âÿ\Ã3ôŒ¯\èQª‚ı\è\ÜscfYe¿,l\Ìs•\ág#\Åj\òÌ¨CGb2Ó„eP³1N™\Õ\ãû0±¨\ò\Z„Ã­\ğ·\Ñ(º\áÎŸ?\ÃFWt¸ü\ò\Ë\ßy\÷\İw—E{ê©§ş\ñk_ûZ\İ*W‚ÁW\ÈZşzZ‰Õp}w\Í·\Ùa‡\n\Ëøä™`Ò«Q27¹V}œz\İX	/œhQ\n~6Sn\Æ!yQS™Cª\Õj&ªd—\É“†©¯\éa_\r©)+j@Áø\Ô)AºÔš}\ZmÄ¬>BAøˆ†\Ún´±;>r\ÒHVcü\ç°}U4\Ï\â@©\ñ\\bL¦¯V\Ø\â\ğ„½d¯¢PXÈˆ\Äs\Ğù™D”„Á\ç\á\ê$*¤\öJ\n\ñ=<½d›ù¸O…Ñ‹\ï_­\Ü\×X¢^t\Â\n–{yjARÄ¸q\ãH¤Tn¿\Ügj¡w\ï\ŞV`Vw\Âk™I(\É\İO[\Ø{\ï½\Ã\Ç\ó\Ç|<Œ\Üı>\÷¹Z°\ÚD\õq\êEvc%D&x\á\î\ì\×/\ÆxR\\^v\â#axjBLR´Y\nIp¾¬)UÀü\î\Ïax‹p\Õ\Îe)\ğ{\Å\ÄÊ°:7/\é˜\"—›i†\Ç\ÂÌ¶#9\0‰7\Úx·®™	i“VløMÉ¯*/WG\Ä\Ú0Ü§N5ª—\n\"E™\'^y}l\÷²\êÔ£³\ë;#Í§½5¨.Ù\Ô/O>¥û	[\å\Âr<£\Ãp\î\ÑvNüt\Â\Íe/µ…£>ú\éE‹},w¬Ñ£Go‘ûL-\ÈDR\ó5w¬V`M \\87ˆºf¬…Zk D‰h’\Ügj¡=\ë\×e7B\å\Ò8\ÌZ”\ç\áš9\÷2û‘\Şs\ÓM1\Ò\àø\İv‹/7œ^.jI<-\" @…™A@™y¹M¦)“ˆ@D\ğM›i|N)°\ßì½ŠYü\Øz\ßø\çAR²BÖ„P©³ °7\õnÈ&WEC¸\rœšM\Ùq:\õa\á\Æ=T6Y{Ö˜\ó}Pı·^vYT\ëGl»m\ì4¥fûu˜F.şvù\å\ñ{û»¨Eyé°ª	wÂ„	}™	ù§Aƒm’;Ì;\÷£»\îºkCùH±‘¢F°¦.E*k1wOm¡G…ºÇ•\Ç\â\ç+4”Û¿D¬T£Qd7‚I3™ei½+ªG‹\\ıkX\ë_dI5\É\\2I“Wv…\ÉR\à\ÛR¹fÃ­¨\à…WŒ\Ú\ÕdBQUí™˜2yGÕ²4¥\r‹\Ù\õ6J<%[f+-©Â—\òŠ:“x\È*MvfsH?v\\\á:X•e\'u4V£H\Ñ©!\àÛ¯ºji \ÒÕ¼P0ş\â>}\"±Š4Ñ™°†¤V\Ï~\òÉƒ}\ï\Êb\ÊdË¥û6ƒUM¸\Ê\÷\å^ Z8è ƒ\Æ\äS‰ş\ğ‡\×\ä>[&ZV\æ\'6‹5…pZU7!w_µ@\ÅR³\éR»-\ğ˜Û·”^T\Ô&£d7&<\ó\ĞC§(Søbx\ÙM\Ø \"¶«€\Ò]øü\ó‘(?$*‘­‡&š„\'!‹§\'NŒ/?OPT‚\É¥—jC´Â•¨ª%¥jHÖ”\Ô]‹C\Ê&£œi:\×a\Ø\î\Úbo¸akH—omho6ÿ\Ñpÿbg5\×&B%£¬bu\ó=ˆVs[İ„w¥$¾¹\Êa&&F„„)~£\ãd\í \à\ÊB6ˆ7|\Ş\Ê\åş.šÁª$\\S\Z}A\Ï9\çœırÇªÄ´iÓ¾Z\ï\ß\ÔW8>Œ˜dP\å\×¬I„+ª \Ñ\ô[\÷\Ë{¥jC‘“™¹}k\áª ^*¯£d7VBd‚\Ù~U¦\èCO„\Æ3•\×oª’U\"\\usM<!	dHÙšıV@\\¨º¸\È\Õ\ïM¦QÁˆYQû7\ÚL™­7y¤6®2‹\ÍZ:j/­\rªy)§¨\"UXÿšB\Åÿ*t,\ÙX3H—\ÏMe³*\ë\ôzv,Ş¹‘Ges?\ê\ï&•\Ë[gC©°x\0Ù²†_ye,yÏ A-\÷\ZW%\á^|\ñ\Å\Ù¨Â‹ù›Q£F}<w¬jœ}\öÙ¯\äQ!\Ú[\\%‡5‰pA	\ÇFWbp\ÏT\í\Í7\ß<Cıƒ\Ü>µ\ào·¥³«!\ñaú£73Y¥ƒ\"œ{\rŠ¾¬¨\õn\Å\Ôz¡­¼`8¯ÉŒJş¬¡¬r-¯.šÁK\Ï+EŒ–\å1QÆ§l4\áÁä¬+uø¶ˆ\éV¦»¶\Õ™†´d\\QÚ®1­PqË¥—\Æ\"\âV™Hus‚¡6)x\×\ëÿ\Æ\r7\Ò\\›\ÆR\ğ$š®;µ\çù\ó¯\ÕX¨şË‡…\ãûA\Ê\ê\ó\"Z!|\ì)oı\îoŒ*7t8\ÓD2„–ı{h«’p%\ä^¢Z8ê¨£n\Í\'‡aÃ†]\èE\Î\'ûvD­\ÜfW\ÈĞ¡Cgtªı\ÓVÀúq<{\ÈB\Ù6úµª\ò[vc²R\è\ÉJ\ÔĞ›J=6H\õ¤Š1{H\Â\ï©2‰§\ì½w\ôo‘$…F™\"d¤+¾·^’L\Í9ø«\Îm¢éˆ¨¬ •k>—ˆÁ&\ï\ØD”aÇ³\ZE,¦\î…]b¥C\ò­ÿ\öoc\r×\âc;£I\ße\ã\Ä$’L§\äR±U-‹\êfÙ£¤rUo\Õp\ÌN;\Åøi#«+BnAP\â\ÂG³bU®\Ë\ÜKTÂÆŒ³K\îX9Ì›7oı@v¿\Ï«Ä†Z¾%w¼f\Ñ(\áv6N:\é¤p™ùko.Ü Q«¨Q \ÛSO=µhUY\Ğ\ì\ÆJ’½8ey\á\r£ù³ˆ\ÒP”\Ú\óƒ\Ğ#!THª2\Ç+ÌœÇŠüRfO\ğEP\Ä\õ6û\"K\Ë\í Á«O8!ÀI‘m5“c\ö¡5Qbİ—\Ä\Ä.…T-8‰ˆûl³M$]\Å\Æ\ÕqTxG·Xm-d®±~¬!\'¢º3PŠR§D¹\r\ğ\Ñ\Õ\Çú†|\nL^š@\ßi\Óa/µ°ª¹\å^¤Z\Øÿış\æ›o®•;V-8\ğ†FUtøŒ¥6²\Çkk\"\á‚Z¹\óµ\n<ú‡[4qÙ•x\á™g\ö\ZpÁq’Q\ò©V¤\Ê\ëT—\Ù*Áˆ¤¨Dj\Ì\Ğa!5\åÿ¨\Û}7\Ş8Î¶\æ\ç\ë\ÚO‚ÁÄ R‘g½q®á…ˆ„\Ô(Ò¥\Ì(iI‰Hk5$i=/ı‡Aİš¨£Š\İu\×hˆmu½™ÿ”e&\Ñ\Ã\ÊVjˆJ\ñ3Ÿ‰\Ê}Z ©…\áúÛ«x®+·rD½²U¬§Wxù]Su“®W\×\÷\Èb`)ˆ.‘±\Æ\Ö1b±Ü‹Ó§\ï:Ó–­gr\á;›p\ïº\ë®{j…‚)d­€t\å63\Ù\çœs\ÎM¹cµ…\ñ\ã\ÇÿS¸¿†Ö¿\ò,Z¹ºo%\á\æ\n¢7ƒVÇª\'xb¸\Ìüµ·V®È·|\ï++d¬‡V/Áİ˜”`”ÑMš—ˆ™\Ô+e\ë\Å6üGp&—\ÄxÈ”\â54EP²¾\É\Ù?8ì°¢\ç\ç?_œÕ§O$%\ê\Ö\ïÅ“\"]ŠMh½aaÓ¦NagªIú\ä¼HT,m­\æ<|g\r\éNy\è¡b\ñ¼yq4¡UHÔ½P\á·\ÈÖ¡v\nm3IÆ¶£›\ö\ï††\Ï\ó¥c\ÈX…‡Jıº\Çz\î\í\íp\Î7Ô¬\r*\ÖgR\ä¼\õ¤ûN$jl½\Î:\Åea”F©	\í3\nQ¡M4{GD‡Z\nÒµ•\Öd\Ñø™o?4\ô\õ—\\\â£Ù¿F &A+7\á\ëc¥ªkyu–FA•\Û\ÄdÎ;\×\n\Ùãµ…¾}ûnt©\õ\ê\å`¤¯Vş\Ü\á~\éK_*6\Úh£\Î\Õ>û\Ù\Ïf·7ŠÏ…¿µ\Â´úšE­a½	´FF2¾\÷´4N[\àq?[±\ÒMü=BvcBP¨\Û>ÿ\Ä½\Í|S|’—‘\ïg²Œ\Ïg2\Éd˜\ì%/¼YüDzo²rDM\Éç§’\Õ[M^­ı„9©`¾z²§V£`…5	\×\Ë×¤xn[Ä„D)i\äœT°\ÎCÁn\ä	ˆtÌ’¥\ÄMúŒ{U\áø\Z\âFº©HÒ•Ê¬®¯\Ùÿ\Ê	4\çAÂ€t]_\å*Ru«S™=Ÿ\ôV…ç¢£@\ö\é\Ù\å\Zrg©\ğ\ÒUj“=V\İX@.Æºj&\Å\Û\ê\0u¾œ:\Öûµ),Á>šı©m)¨£\Ú\ÈKˆ˜9æ˜Ÿı\îw¿\Ëf–­#Gü\ô®»\îú\çÜ±kA]‡\ê\ã4‹5\ÕRHøa\à¦\Üy›…´\î\È\Ìn¬D \É#•\õ\ã\ñ¶[E\ZE¾\Ñ\ïü‡ˆCl\Ão\ÄI™)˜Z\ß\ğ¢QÁŠ\\§¬Ü›š\Ø^¤\×\Èpœ‘’|š\ÌCºm5ä‡œ‘	\ëAÌ­$	±¶ˆ\ÓpÜ½\ò2ù¹2\é\Ø¢‘\â8i\Í5\ÖI%\é&x&×~z$Ë¨n—<j\Óùÿ\î\Óg“\ç\ë¾S(¯©&e\Ê\ÂI\Å\Ê\Ñ	°cr\r1{¶F\îE¶œš\n•\Í\õ\è\0ù¸FR¡…\ÓùŒb(y\Ï\Æs\r-®\æ\ë\ß\ö¢³	\×\ŞHÊ¦\Ù\ë\ñ\ã\Çß˜;V½\èÓ§\Ïm¹c×‚zª·\ÜrKK–\ö^\Ó	W\ÈV£5jÁH¥*c\Í »±\Zª†‰­5Á…€O\ß^½b­[«) \ä•2µ¼\ÔTE<*\Êp\ÖË¬\ô\ßqh\È¼¶\Õ\ë\áR¤&¶,À¨±(\Ğ\Ê\Ø\ÔÊ†\è\\\"¡0¢W˜q#JŞ¦8aeY%”­NF\ô¯šr×™ u	Hqz&B\Å\Òzi ø:[B\Â5]\Ù$N \í¤\æÓ²CM:o:WªQk²\ñjF|V\Ï3\×tzÃ¯¸\"ª\\	l\ê¦D£\ï\Í=S¸Ö”³?×¤§\ëf½\ĞÂ’‚I¸\Ê\æ\í¹\çÙ—©x\Ì\ï¿ÿşv¹\ãÕ‹«®ºj£­·\Şú/¹\ã\×¢¬>N3X\Ó	ú\÷\ïÿ^\îÜB¬t+\'\Ê*‘İ˜\ğ\è=\÷,-XbUW*\Ö\ËO\å\ò\0M”QI”\Æ\"@şŸ²¿·)-\r¹ J‹¼Š¡v½–‚%b\Ä\ÇÊ€Cìˆbm+a\"7\ì+\Ö\×DEi‚ˆ27kœOÔ„HJ>…®‰  ü\Æ\ÜtS¬°eH/jÁùÄ·\"8D‰¼w^o½¥¤\Ğ\n\Ë_\'“”®\Ï LJVG@I³ø¶\Î)E™\Í\âw©y¾¢µ†„¥\ä\ê@¾L‡\ã>=C#\0•\Øv*WG™|\ëÔ¨o5\"¨\\!bQ\ÄR\'\Ë\è\ÆsÎ‰#±¸\ß]‹\ã­I¸Vth4j`\ğ\àÁo†\Ï~´úXb¿ı\ö»;wüZ\Ö\ôH–¢/	\÷¯ø\ÑG=½\ğwÃ¨>v«İ˜ \ö\ö² ­ƒª\ÈÁ\ËlL=…«h^Cš² ¨1\nRŠ¯I\Z9úHGCˆ\"):\äR=¹\ÓV³ú¯\ô`¤A­º/\\¸BX\0i†\Õ\ó\Â~\ö¡\Ä)9×p£!5û@CX2D¶ˆ¨b×®\ÃÑqº\'\Ê\ÜÂ˜\î\ÇÂ˜É¢09¥Z—\çeˆ\ÎNA\ê:\ÄÊš‰P¸&ŸM\ß[	$j$\àšt,Sƒâ–œ\à>\Çu\òƒ]#\ó)K(Ñ¸¿\Ã\ó\÷½U6\Ç\Ó\é˜È¤\Æ\ÅNû®\Ûu\×X¾‘×¾\äy\Ä\ÅCı\Û^t\á>\õ\ÔS7Z\ó{\ì±?¾øâ‹¯\Ì˜µ\Ìx¤\Z³g\Ï~$¼\ğ/62y\Æ;–\î[}¢$Ü¿B	\ÇFWc®\ßÿµ\ÌY\ÔBvc%,¯rW\êT\ä¯\ÂN\İRE…Š¢ø¨6\ñ¹ˆ\0)yaM\Ä\ğn),DŒ\ğ¨_ä„©HDh\È]ï‚‘T—^\õ(@Õ»\ÙV*d\çz1œ\ß!t\Ê	…GK\Ù•KA\")JÖÚ±!NnU#6\n\Õu\'\Ä=\óbŸZW\Û@\n­$\ç2\Ø-\\·I5ŠŠ\éu^$©\ó\ĞQ\é<L¢!]d\ÌOvj\Ö3r!tRpuX\é¾5\×\æÜ®\Ûu±}LŠ)j£\ÆBµÊµ¯t\Ş-ƒº·8\é#¿ş\õ\Â\"¡·„\ó.Y¢ekqu\á^{\íµ\ğcs/S[>\ÆSm/\ZT\0\É\í\Í\Äj†p‘=E\×<P}\Í…K\çÔŠNi>së­·¶$£¬²A\Ü\ôÿ\Ù\áyù²V(…gi\ò%EP€H	.KrTO‰‰h@\Ì…j\ôS/L›É¦’(k5*NJªU~‘é¼ ”©leR*5\×a¦\Şù¨\ê3ƒ\ò\ÑQP~È\÷JM\"Q\÷á³²\Õ\è\Ñ)$…\\İ•\ãQ¥şŸ\öK„\çgŸ\×¨!Á¦ %%xv\Î\rHY\Z±L=Q\Ö(\ÓQ\r\ì\Û7\Ú0\"\r¨c¡^:9Şµÿ{\öqQ\Ù~\\\ÓÁ±\Ä›\Ä\ã\Ó*T¡ù>%KP\ä:^.k„º\Õ9Mº\ë®{Ÿ»®\ğ\÷\Ñ(:ƒp,X°A£v \é\öÆ©6C¸»…w”\ÑhE‚za\r´fJ8Z\n©úX­Fv#Ì™6­§”Ö \æ¶\õ³¿wT\ÜHKz+\ÏÑ‹m˜\î%G\0|\\¡Q^\ô;®¹&zœ¼ZcÑ¤Ugˆl\âB¦+k\Üd“8\ì¨Oi†\á\Õ\Î\ãø\È_Aa^)Aø\Î\Ö3¬¶¡¾!¾\ë¡MZ¥¡V£8\ãD\\¸gÿº6Šek’\Ú\Ôø\Æ\Ô=\"g7\ğK©^\×!T\Îı8·\"@\ßÄ‹œ­ZquPš7…\á=b\å¯\"\ê=ÃˆB\'\'TK2‰\Î,5j¹Òšq=”±Œ2¡n\ê\â\ÆN¤¢ssÖ“ë½¤\ğ\Ğÿ\÷‘x}?&\n\Å(‡\ö‘7/n·­\Ğ„KP™¹—©«\Ãû¬Š\ZÔ¢QÂ¥\æºsñš¶ \ãU·6w\ßmÁ¤[\îx­Dvc\Â\ô\Ğ3ZR¦Ñ»\í\Õ+\Æoª{khL\Í!\'	†Á^zCa\ê\ÖÊ½c\Ã>\È)²\Z\ÏRK\ôø?\ï3‘S[O,\Zù¨U+^\Ô\ä/\á!X\çÑ%\Ï\Ô\Ğ\é#ÿD¶<U\õ`©8\÷$²‚º\ÕQ\ğ?­€\àÿî­\æ\óˆ\å\â^\Ø.®‰ëˆ 5o„€Ü”v<:(W\ÊrA¾)\í™\åpA¸7ExN\r/ !ş)¤ø\èB\Ğs%\ÉV6\ß\ÛÄ³HÄ«\ó`ˆ\á¥\ó«\Ã\Ät£C–ª£‰şP\0G¼\î}Aı¿İ¢\ò&\\Y[{‘ºX\Zí™¬)	wº%\á¢Œ&(7CR—\Ò\Ò\Ü&Â¼ü¢™}:&xx¶^Z\Ã}„È¯D^l*5Å™\ò}m¯Ê•k\÷‰¬L\n²»6\äfx\ÏjP*1E!¤\ë1`¢\ryQ™~‘4\ï9®¢:Ç§\Úy\Ãm©\Ûê†°“\ÚE®V\ç\Ø:$\÷\îx:\×jE]†Hˆk\Ü#t—{l$:“\ÎÀşm¿\ç\ëœ\Î\Ï\ßu‰\Î&…\İ\éDX\'>b\×\Ñ\è+›gx~ D%®\Åâ®1üaÓ’ß&\Üx Ÿß¹©»\àÀ0\n™={vSC\ï’p—¡[®\õ®¼\ÌHQ\Z\Ş\îˆZ2\á…H1e\Ë\ô³I\'$G™–¦P(\äC¡\"D¾­b1H\é*\"“”i=²™]Ÿıl\ô4Å»\ò;\r³–XZj\Ñ>¼ZJ[úª\É>\ñºÈˆ\ÒD†—\â>)s~o\ò¤›iˆLt›\Ä\ó@ˆj4\ğ†Sø\ß™R¬Š\É B\×\ËG¯\Ü/Ü‡\ë\È-{&%^h\Î!jB\\°ˆv\É4\÷(Œ\Ìv\×\âşùÁ§\î³O\ì,\Å\éV6 \Ô^>3Â…\ÃC\Ç\Ö*uM¸&er/Qw‚\Ô\â;š\\¢$\Üeè–„;mÂ„¾\İs\ÏCf~)/\Ğl;‚C$\Z‚A¦†®ˆ\åªNˆ‹Cš]Gn\È\Z\Ù \ê±!]\n·\êE§p«\'s\ÚjQgÀ\Ï5qG%\Z.§†¨\Ğ\Âÿ•¼ wï¨°İƒNB”ƒ\Ê\\ga!E\ÃtŠT\İª°\Ún´¹>*—g«CIM\ô«iR»üT\ç?q\÷\İ\ãd\ç&¾˜§+~9…\ÚiÔ«¦s\Ğù±/\Òuz¾®\Û}\ò\Ù5\Ï±#nu x\ñRM¸}7||`Ï£²ù.\Æ£)<C+ı\n-û\÷\Ñ(:’pŸx\â‰Ş–?É½D\İ	&Ïš\Í/	wº­‡†\é=((\Ãw6‰²GFŠBR¥\Ô>† =>\õ©\â´ı\ö‹a[¶ªR’\Ô\Z5I\İ\òo)3Y\\¢šiHK\'@­¼\é¦q\Æ_ˆš¡³™~‘†øŸÕ€\ì)\é¾Î\ğ)sQˆ)U‡Mµ§\é`tF\")œ;\r\á)~DKS¼:“ºÃª––g\ßT®\"a?\÷!\Üi§‰\Çdh¬\Z$\n¾MGB?x\Ë-1	Ã¨@ı\ç\É-C\äsjSˆ±Fº\ìùÓ§7UÌ¥\ZI¸Ö¼\íÊ\å\Ä\É\İg[(	wº%\á\ò\ï\Æ\İv\ÛdaM^T3ûˆq¾2wn$Mş-(l\Ã´€c\Ü\ç×¿\ÃZDC\í!d$DE\"Z„Œ\ì&Õ—¬\'\Ë\â(ŠC™\ÕÓ¨D„Á{µ–ø§üW\çs„„H\r­\Ó\ğ\Ú\õ#=„\Å#udU\Ï\Ä]#\ÍıR»”ªt\á\Â\å|\é™\Ü3hP´7ø\Æ:$JP¢®ª\ÕYI\á\õ\÷h9\"“b”®…´b\Ï>\ÙH\Ü3w.Š9k&\Ê±\Õ8¨[~­\ë&!+›\ã8OªÁ\æ–Z\öo¤t\áZluP·	bˆ\Ï?ÿüpkùû­…’p—¡[n §M\ï¾\ñ\Æ7\Är~ıŸˆ„`\ÂGCNH\á!\Ùf&¦\á©G„f\È\ëÿ¯rA®†\î2ªI\òz\r¡·CWŠ\Ê–\ò“š²¾šiT kBb¼R\äz)F\é\ÄH\È>¬\Ãh\ÄØ‘\ÍH€\Ú9‘:C~j1\Z¶_q\Üq‘|y¬|\ç¾ùÍ¨\Ğİ‡\ÍDš{\ğ¼©Uv…Nç„M”!e\Íı°/ºQo\ÖqœS\í^#\ôÁa³¸šıqR¹¼p…mB\ËşÔ‹\"\\‹\æ^\îŒfrùK\Â]†nk)<†6\ê\ÈX\â\"\rª\ÑKH„:	5²Â­p&*\ÉRWüCjL=Y~m\Ì\ä\nJOœiZ#L†\Ó^a\ØÊª\ğYd¬\Äk’\ÇgS6W£\Í5úl%¡\"©\ö¬c4\â9\Ç\æZ2\ç¯‹(Sd\ÄÀ\óÎ‹!l¹p.…syvˆ™\r\"Á\Äs7\ò\ĞyQ¥:\Å.2Ù¦sQ¶,qË¬\r\ß/^…0	¼n\ñ\È\Â\Úbh[ø~­b!,LˆpA\ìpP\êM\×j…\"\ÜFV\Í\nRø•ÚªiÓ¦\õTW5w-µ€]!¶$\Üeè¶„{\î!‡DzyP`&Ê¼È¬^ŸÿSn&}¨_9zi©J¾¨!s\Ê\ò\âS\Zú½ì²¥CÕ\×[/\Ú‚ü/\n\ç¤@ºbA\ÅúJ¿š„˜E8\ò¡š‰•Z\Ñ~”Ÿû¨·97\õ®\ó¡P\ÓPşa(\Ï/moC¦wr”¨ \Æ\ğÅøbH] Q\ç•x\"W\ñ\ßr\Ì\Óvm’.,—\Ã+ÿeMˆsN£*xT\èıËµ×I×œ|rü>+¢\×ù©8¿(\êv»@\Ê:A*<´\ì\ßI=8ø\àƒ[N¸V_Í½8m\ñ7z\Õ,¼È¹k©„\Â\á•+P(\Ø\Ş\Èê¾•„[½’Ek2\áV?\ë„N\'\Ü\ğR¯\È\äkZ\r*À°\ò \Í6+F\r’a9O”‚¥v)Sjbc¥¨\òp‘\'b°OªQË‡5p`\ñ\åO|\"ªW\Ë\í aC\İÔ¨69|F+KxÁ“\Â2¡D™!¤4)·m\êÔ©‘ti\'\òS¾0‘\áœ9sŠwB‡\Ğ\ŞQ1{Ö¬\í\á\Ù\ós\Å\r\ò\ëp¼	7d\ë9\ãS»)\áù2$®®A[–^\ç%\"\Â\÷!|md\Å&«›½·\Ø\"¦û~t \"\Z./\ä9\ÇŸıiû\ì#\ò¤\éÚ¸=z\ôh	\á>ı\ô\ÓKI\è[\á\Z«_š¶ §_½Ï¾\ØN\Å^	‹\æ¶\'Lœ8±\ïV[m•½¦K¾T¯° .D\îx9$\ÂE&†\ï±\ò89\ÔC¸­*Qø\ÜsÏµ¹jB½@¤¹\í\ÕX\á~!¹\Ïş\ó+lo†p]\ò>»\ñ†\ğ’K\ñ”J\ÊÏ£¨\Äy\Zú\"O“O\çtPœ|1©2mÂ„¾?^´h}KŠ¶ù\æÑ‡U‘K,¨Iş\äu§‹•[‡Lºk®Qo|]jK-×¤†)-J¼G™c­\àj¦Æ»¿\Êh‚V5›La“B&“ÌˆÂ„–\Ê6Q(\ÙÄ›¬>#\n‘¼j„™:,0‚pLuoù·©#S\ÃÁˆBÊ¶\Ğ4™x\Õ\á`\ĞGœ\è¡Î»~\å\öF\ĞjKÁL~\õ³2\ì:\Ç¼w\îx‰Å‹¯\ÛL‡C\Âw³¨\Îg^Z\n\Ë\Ğ\í,…Á\\U\r»€\êW\Ë?d yÿ\Ã.¿<®”+³¬\ò³a\è:D\0½ ~/®I$É—”ºZ‹l5¾pZr=\ÒK)°~Fº&V\çFùS®F\î—M€l=KuL¤‰%b\'ú@§&Q³\rÒ’A{@†²E\Â\'‡ÿ+>N\İ\"X\ñ\Ê\Õw|Ix\ÇÖ¨–\ôÄƒ^¾é¥½[M¸½z\õÊ¾4µÀ»=®¶H{ l\àv\Ûm—½¶ZP+wØ°au­Q\î2t\Â\rC\×øB\ÉD\â¯.zşù\Í=z¸I\ñ¡T–—_Û€:ªü|¢5\æ%ºdÉ—\íqX¤°²\'[r3,f) \ÊV\n/¯Q¤„úf\ï©]\êWş¿¦Õµy.²\æÔ®P»—7\ÎGGª&•\õ <ŒU`\Û\Âg’c4!\ã\ïG\ç³\Úx\åâ–]47\Íy¸¼t\ßgh+|­D+	—Jm”¼\Ô9Ez¹\ãu\æÎ»q\ïŞ½³\×\Öx\ß\Õ\ÇÊ¡$\Üe\èV\n—k²\ê\Ù\nÿ›Ì²okF\Ü<û©§ü5¬pu¨`\ÃS\Ñ”–8^\Şge\Ö$\êrF0Â–5,d‰a²Gˆ…\ç_C_‹ ŠjP\àETu×•š\è“Y\ím\'$sx\ÈS&˜\È“°<Š—Å£„˜T*\Õ\ê{\òe&\Ù<¡£®ú\Û\ën\ğ“—^Z:D}-üa\Êr“\İmC«6ŠV®bÖÖmå‚Í‚œ»¶¶ ¨\ò†¹\ãU¢$\Üe\èV„+lª·[j\Åd—Z\n,ƒ%ùø\Ë\íS‰W\ç\Ïßİ \æ«0µV‘fu3“\Îe\'ˆl0™#B\Ñ\ÙU\È8eµi7‡c¦\õ\ÃL\ğ e“H­&]\0i\"ª¦\óHQjE\è˜(H\Ä\ØlSoB”µ\Ê7ZoŒO\ë|2\çX<|\\\ÑF@ır~e\Äu×½\'[0*û_–\Ú\Íı®•h\á¾:ŒF\×+\Ûr\Ë-;tÙ”z\ñ\àƒ^¡m\î\Z\Û\ÂA\ÜT«\Z%\á.C·\"Ü•-‰†\ñ\ÛN0¡o\îw9(5H\á\ÊÑ¯5\Ùe¨¬\è\ö\É{\ì—{‘‘†dsu\r¨\\…¼.o\×,¾XS\ÄSYØ¥=\r\É#1d[o\ØØ¤»\îŠ\×\Î/UŒ\ÆdûƒR7¬7\á\è\Ú%\Ô\ÓD@¸‘	\õ\é\'ºD9°DIxV²\ÙX@ün©»j1Œ¿ıvke¿“UV\î\ÕW_ı!Õ—{ajÁ’×­š)o/N;\í´\ì5¶\Ñs\æ\Ìi\Ó?/	wºİ¤Y+A\é™mGµ\Z\Â5\æW\ò|sß‹\0…e™\è¡r\Ù¼e\ä\ãj\ì¦t\Ö\ö4		&¦\ZQ\Í<h2»ÅªˆÏ¢Œ&©Ä¶ˆW‡HŒz¢,LR¦GB2O\Ùa2\ñb|\íƒFgÛ°Yø\ë|n£‹\ğ±\ì\÷±ª\Ğ\n\Â\Êu\ĞAE²È½09Ø·³\ÖÓª2\ãøÉ¹kmgœqFøxş˜P\î2¬±„k\ÒM\Ğ<2xdÌ˜°\é¯M>h€¤Rc¢\Ã\Æg3Ë,\Å\ë3\âQ¥¬R¸\Ï kÿWi[Ò„•\'X\é\\m5\Çg°œ\Ïg¨L\ñ«Q•\ÖqŸ¡ˆ\Ó\õ‚\ë\íT\Í\Îa¨\Ï\÷¶¤¢>•\×?·\äœ\âl\Å8\'e­\rï›Šgåˆ¡UAX˜\ëm\à¾\ÙÖ\É~«\Z­ \\‰\Ôj\îe©\Ñ	\õx ‰fBÄ¨ú¶TnI¸Ë°\Æ®\ÙpDj\Æ<­p«&§’ƒšŠ_\Ô$P®‰+E.ü^¤$Z\Âş‘tÁ\ns2)g’‡\é|lŠPZ²\Ä$XO_+\"€b¥0\Åû<?µÙ†\ô©O5)\Ø ƒ.¸ q\ò|\İ’©»\ï¾‹\ÖH\ÃE\ØZ\Ê*“:­ƒÑ‰¡Œ\åxLŒ…]³\ßCW@+\÷„Nˆ\Ä\ÓÔ˜­>Îª†´]×•»\ŞZ\"\Ö!%¢%\ó¹Z°Ñª“\ëH\ğù-—»\ï¶pı\õ\×#©\ì1[…\ì\ÆVKyŠ\å­lj¸&’‚¤‚ù²ü\ÈZMá–´D%Šl\Ò2\ä†\Ûb‚\ÕH5\Îş\ö·cª*r2\äF¤+k¬“QŠ\ô˜œR;·=D[\Ù\Ükÿ\ÓO©\Òl–\×_«˜¹%\"¼\ëµù\óc™0/Yzüd×¥DcZ\ÉW£³\á\é\òn\'6Y´º3\Ñ^Â•\00dÈ9W^ye\ÑFuÁ\È2Üƒn\è^\ôˆ#\î\É„¼\å>W\×ŸM«\à\Şr\÷\İ&O|V\îX­Dvc« ¾‚¦\Ê\ê_”&Å‡py\ÈGv™¤i©¹\Æ\ó¤\ö.¥«!¥f\Ù~\'\Â\ĞÛ\\ˆÂ’Aµm ü´0\â\Ê\ZÅ‰\ì	V7j·z\"\ÏgXˆqeMÌ¬\"?H\÷\Äp¿T\ï\Ôq\ã\â³\Ğt\n–7Á‹v&\Èd–ynT0[‚¥ \Ğsƒ\Ç\î½w@øx\ö;\è*hÕ¤Y‰\İÙ­R¤\Ä*\ão”,)Š¹X¹Ar\ò©¥&4\å‰t‹A\òÒ‘‘\å8©4¬&/µ{\ë\å—G\"OYnišpjd-µ\ÔÜ‡\ôYv‚,K¶W²HVÖ®4[a^&¸”¶t½I³¬‡t¹N\ÉD¢4^\Ï\àÅ‹\ã\Ï\n½Sùo#Q#«\n%\á–(\ÑÁ„k•q»ˆ¢²‰8@z‚\òw*\áJp¨®¸E\Ù&EIA\"jŸEtbpDÿş1~7fH’)x§\n·\ğCA:,\ÅXwœm Ù»ú\õ‹!Z7sN,0c7\Òø±\õ4\÷ \Ã\Ñ9\Ä2Œk­K[Z\"H\ìqZƒ\å\Â7–\Í\':­á¾…€©e!&šW-ı\÷\ÙN\nµ%\á–(Ñ„T\ßÁ\È\Ö\ê´\Õ\Ãm¤C©I\r6Ü·x\"¿´r\æ^\ã{R’,Ê³†š*“qw\Ì%S¤F\ÅZ\öÜ¾H\×yûoCÀFp®¥fˆ¯ƒ@´gp@\ôQ/=\ò\È8\éWoS\É7³¦U\\—‰/«j(@X)}\r\õ,qB\ÛÁ¹¼uå„›¥Ì¿Ğ²\ßAWBI¸%Jt \á*t¢4\àw¾ú\Õ\å®Ù†\ä\î‰aHmQC¥ÿ¨\×\êÆ›•ºj(„¨L“FÔ¡I±z\âd…`!4\Äf‚M†\0\á\×K¶\Z\Ò2¦\àºR†&\ãø§V\İEŒm)eŠ•-B±³„xÅ•/n¿=\ê%ª‚\õ\ñ¯|%F#8{\ÖEØŸ=\â9P¾\ìvŠ\ì=	%—sŒ\Ód¿‡®‚’pK”\è`KA\0DB‘Š3}\ó\ÕWc\Èw\ë­1L¨”šºV\'ÈµDR\È\Æÿ©Z“Nµ$4û\'?˜Õ€l\áÀ0t·`£\İH—\âl¤Q\à¼V¹\ÔrpL¶\0Z\ò…\ë«nˆ\Úù¬\è %u/\"‚y ;Mx›z´,O\Ûf„À†q\İuÑ›¾\ê\Äc\Òw\r¢4B\Ë~]%\á–(\ÑÁ„›V£Ub\ğ¾›o*Ñ™RÁ*‘–5\Îrd•\Z¥+$Œ\ò;jû\íc¨™.µšc	\í¢šMBI³B…üu\Ö£sI+mt)v\Óe¼¹~\n•% 8\ÅÎ¦†¤M\Ô!\Öd?8¯\ë7Á‡€mg˜HcU\è„d§	ùra?\÷£t¦5<iç†®œ\ğPn‰une•ıFa’	lH\ò\è=\ãD•ª\èŒ†\ÑTouC2À~\0±¨\ì\0\ä}` :¿\Ë5ª•r”©e¦\ß\Ê\Î\ÏOFN)‹Á¹	\Çy-¨\í\êP¯zš\ë®¥û?ş\ñ\â‹ıh<¦E«=k×’V\ÊPÿÀÏ®_\ÔÄ¢Y³ba2\ì\Ä(¾S*\î_kIN6ŒZ\n\Ö\ó;\ÏmW^\é+<\÷§jTrkcÇU¥(û»F°SxÖ­ \ÜVeÍœ9s\Û\Ü\öFa\Õ\à\ÚQ\'¸­*~ÿı\÷7¼\Ìz\÷\İw_K\Â\r§L™\"¥-û»F`i¤W_}u\Ü\ï\Zµ\æfÍšÕ’\ïÿ\ÑGm\è\ï1»±Õ¸wĞ \na›$’)¥\Z™t\×ŸúTŒ§e1¤–|Uj\Ø½Ÿ\r­©\Õ\"ø¦\nÕ´Õ¬©&r\0‘\õ\í\Õk©\×áœ\ãg×¤¬\è‡JuJ…¦\ôÚ¶š‰9\÷\ã¸ª\ã!Eao)®X–İ›‹GX–rM–‡\Î\á™I“¢\â&\êB…5j\Ü\õ±DcT®‚¡“b)„Q‚x»\ì3\ïj(n‰D¸	SB)4Kş¿\á2»Á\Ä\Ù\Ò8İ ú\ÄŠN\èUG\"YQV¡ s\r9\'›à¹ 4E!Xı–ªu.„ˆ¸\ÔY0\á\Ä\nHf\æŸ¥DMÎ‰J`cT«\Õ\\³?•\Å\àŠ\õXzH:®\Ã1$lˆF\Ä\êÚŠ\'6!¨™@cQHtH\Ë\çXF\Şu»> h\İ¢UD<<–¬7\ÕYh%\áR:F]=\öØ‘VÅ1c†ü\İ\ö“\Ñe?û$LŸ>}G¹\ö¹ı\ì§`x\îw%J´Ù7/^—Z\åC\Æ8\Ò@0I]\"MD‰øD!˜lOk\â\Í\Ê\âU+“b\ÔÃ’$jù\Å	º (\Å\à\òD\r½-\È(…‘YÁBH\×\Ñ;\î\'ª\Ô\ë5eZEˆ|\æ;¯½6\Æ\ì&Õ½²\Æo=j‡\"\á~g³\Í\â\ñù\Ó\Ô6\âM\÷‚te\Ã\İ7dHu3±&*Ás\ö§\Ğ\Ï>\ğÀx\İb”)rkŠY\'\îù\'hÉ°³³\Ñ\n\ÂE´?°0\æA\Å\ÕwQ¤\Ä2\äWd\ê3_w\İu\ï\í·\ß~…\Å&\í†\çzÀ§Ÿ~z‘³]X®\ó\ì³\Ï.Z1|-Q¢Ùg&O>\Ël<\õ†LÒŒ<r£j\Ù&¼\ë}A)R\Åq\ÈP\àj&°üœ>\ï_\öÀ\Ä;îˆµ¨Ä\×[/†O\İpæ™‘\ğ4\ä\ìÿc‡\r‹v€\Â\ç”.‚\æ‘\"x¥-€ùJØ¯z2¬V3)È®PLÇºn\ÖhS\ÄGtC\"]j\İuº\Ç\Ãù\Å‹\\`3°„y‰V‚\ñ\Öj\ğâ·‚p/½\ô\ÒxE\\x\ËO„\Î\ÇÊ²x#·|N\"\Ü\Ë.»¬?~|\ÄÈ‘#\ãÊ½‡…È‰jWU\à*	·DG\"»±³À\ë\âeF^RAŒ=\rPÁÌ½\ğ®·^{-z·\öQ\Ø1!\â\Ô4\ËÁ\âŠH\Ì\ğ5@]Jª@¤&¶.9\âˆl\ê\Ø\Úa&\Ö®¸X$iÁE\nÔ¹¥ß¾ıú\ë5\'\ê4j<ù²CÃ½\ÈSë‚F\èTµ*d„IG¦\âE0\È ³:[A\âCT\É\ó7\ñº\Ôû]\ôü\ó›‡\ÃfŸawA{	\×Ê·j\ÂR³/¿ü\òº¹}ªp\÷\ßÿ\âşû\ï7+ºtûO~\ò“Hº®\çÖªE3K\Â-Ñ‘\Èn\ì,,˜9s[n¬Œ°SP…j\ÅÊªBª\"¨Eµ$9 CUÀ$T6cT0\ÒEb\ÈÖªµj\Ä\òh%	\×\â\Ç\æšZ\Ê%R\Úl\áY²¹,gsQ®\Z\ÆS\à\n¨W§\ğ²’Ç«\Ò/Z€T­T|Ä’I.0	\æ˜H\ñ»^)É®\ÍäšŒ2>2Á\óUÁşp=A	7½<yWA+.;Á\Úd\õV¹ª \Ü\ğ\ã\ò¿£t\Ù\ÕKï”„[¢#‘\İØ™xqú\ôM¤B«\ì%]•¿Š˜\Z—EqJ.Hv@e\ã×šD3\ÙD[1˜²L$\Çm+LÁ›3ƒšµ?Uya\ï\Şq\è/\õ–!B\àG\çI\ßBš©æ˜ˆ-V™0\Ñ7;tŠ\ìP\Î\È?E˜¬3\áÇ®~\å•\ñ\âj‘®,2\Ñ	<\æD\Ğ;-©ı\ğ\òJ–V\é.h\á7\îbV€%\ÒO=\õ\Ô\â\Æo|c\âÄ‰}M\å\ö¯E¸\ï¿ÿ~1`À€\Â\ï¸\\¤GI¸%:Ù«\Ï=\ò\Èqq\ë£\nA±”\"4;o˜\Â\Ç\í%.P”\"—Z•L`\"iùl­„\nQ¼^\Ä\'¢Àşü\Û%q­\Ñ\ãU\ÅKˆ–z¾<İm\ë(°<„ŒQ¼&½¤\ê¦\ëÔ­NBsn¤K©\Æ{ú\ô§£Ua^\Ñ–\ñq’Oaj	–;-û¬º#ZA¸\ğ\Ì3\Ï\ìu\Í5\×|Ø§OŸH˜{ü\ñ\Ç£G^A\õ&wh\è¸‘sC‡=9tp7„‘’\åÇ¡:³$\Ü‰\ì\ÆU…@˜\ÛR·‡\Úf%„\Ë\Ï\"\Ø©Ê‹  `\ï4(Fø\Ù\Ğ?e°I…­nT¨¬/–…\ô`)D\Íşˆ\Úb©\ñd‘î¾t\Å\r«vf\Ò\n\ËBşÔµø`\ÄO©š\ì3¹¶xŞ¼˜š+\îV4	–\"gq ^\Ê\Ûd»\à\ĞpnÛœŸ\ß,\ôJ-ûŒº+ZE¸•˜7o\Ş\Æ\×^{\í{\ï½wŒX¨°O„+J\á\ĞC-9\ä\è#jûÿª\ÜJ\Â-Ñ‘\Èn\\\Õx%¼HŠj¿\ñ\ò\Ë\ë0\à\rvC\î\÷»Q\"5>¯xİ…A©Š_5±…H%\n /¨\åÛ²\Ô2 rG~EYS)L£P)W\ö†¸\İs:h\éjBµLr\ñl©l«7˜\ğ²t9ul‰„>yÄˆ˜\ÉFM\ßz\ÅKW¡p}|i“ –‚ĞµÛ®ºÊ©³Ï¥;£#7§‹TÇŒ3¤r{\"\\K\ó\Z4h\ğm*7»œJI¸%:Ù]	\Ö\ê\âmªpnP(\âd)F]<T‘	fù%˜\Üş…\Ì\Ø\Ôl®)\Ï(Ö—Ok…]©¾Ô¥HTÌ¿&\íT\çú\Å;\ï\Ä\ì15x\Ï\r\ÃP)Æ§{‘w\Ûmi=\\“_\n\å ]q¼\Îm»X`\n<vˆe•\ñ†cŒ\í¦›\Æ\êcAE\Ï\Ù\ÔzK\Òq»\"ZA¸u\êÔ©Ë©R‡¿	$Z½M…‡»\\ª«01Š7—&œ—G,I¢ú\÷%J´Ù]	/Í½ù\ÑAMª¡€\èL I\×\õU\ÆW†‡¼Ö¤l\ZFšµ\Z\ï•2MC}a\\Ô«è´”Û‚?\Ë*¬ÀWeWX©\á¼@¼j\Ñ\òg\Ù&\í´\ÏIjy&\ZÁä™‰9\õ\ìG\õ*Â£\ğøÀ\ó\Î\ö¶\ö›\á%—”½ÿ\Õ\í%\\\Ùa^xaÑ»w\ï¸øaß¾}^\î1\Ç.°e\Ô+?S‹peŸQ½PQ–W4„Um\Å\êV¹W\î_¢D#\Èn\ìj@V²Ò.¥k(†\à<\Ğ\ãƒÒ´B\òB\rP¬@uR\Å,1°Ô¨v\Â\á[o¶d{J¦0©¥‰\ñe P\Åd\Ä\ì*T#\â@—\É4ŸgkBMk¨™<3‘\Ç‘Ü ³\ĞI\0uü\Ê\Z”>\Ú\n…»p\á\Â\r,¾(«\ñµ:t\è\Ğˆ²z\É\ö}\î¹\çÔ¯\\\îw¢|Vzp\õï„Š\Õ\Âm·\İ6¹zÿ%\êEvcW„\Â\ã2Ó¤\Í\"T\ä\Ú7¼ÄˆN½+#@“m~o\òË„XeC˜Ôª\á½I/˜§z\Ò\î»×ŸqF\\>‡:U\ÓÁ\ç)^\ÉT*\ÏVhš¨†D\î,\ñµ¢.<ü\ğb\ô€\Ñ\â0a\'KL\Ê†-œ{nŒ¼`]°‚º^£†«\é\á–(\Ñ]\İ\ØU\ñ\ìCÂ»•9\ÆVD6cÚ„	}\à~\n\ã\ÜÔ¡:\"”D .a‚\Ì5>«,¯GÆŒ‰…¼\í\Ø…»\óz\ëE\õŠMt±(\\U¼DB i5}¥\åN¸ã¨R{.)ù(‚\â\èvˆ1»\"„|™XcWX\â\ğm¶‰‰Hš\r!.w«3J\Â-Q¢›nB Ğµ\ß~ı\õl°;’C‚\Òz\Õ)0œç¯ª\Ì5#®Éµ;®½6&!TZ¢ (d\Åq¬µ\Ç\Ò\nÁ\n\á \ë\É#GF\âV\Ïw`\ØOF[\å1L„Iº`Q¤m	2\Ç$8¼¶’JU«+J\Â-Q¢›n[$;-%>\ì³\á†q\òL\â\õ*Õ–ª©Ä©<c_X²„¥\×‘‘	&\Æ\Ö\n&º1\õ\ëÿˆ\Ù*,~.k¢\òX	¶³ f¶¨¸twEI¸%J\ÔI¸­ªŸ› h\ãÇ7UœıÌ:µ§\É4e·\nCyq®È´’%|iuŠ6\Ù$–R”:\ìwB\ÄL‚Y‘b\Êı\÷\Ç‘\î”{\ï!\\¼Y¶\0Á1U»\æ¼\óŠq#G`oŒ½\õ\Ö)’ø\Ê…m¸—›9o\â>-ZÔ’º	¹‰¢f \ZWn{£\Ø5Œ<ZA¸­ZÉ¢ºJX{0şüº¿\ã¶ ‹.·½QLnÑ²ù&s\ÛE{VŒ©DuJ{ i&·½QT‡)®Ù«\æÏ˜±£º\Ô-/uş\ç1´&Ç¦Nš´\Ü&Õª$K€= ş\×Dûu*d\î\÷RŸ\Z7®M\ò/\ñW\È\ò*n‰5Ù«3(Î•ù¨3§L9)\ï¼\Şz±Æ(…¥ù—²•\Í\öx‹ÖZSPZ\n%J¬„\Û,Ö„ä„DI¸%J”„[¢“Pn‰%\á–\è$”„[¢DI¸%:	%\á–(Qn‰NBI¸%J”„[¢“p\ÔQG\Å\åÍ•=¬ş]‰k\n²K”h5$tH°ún\î\÷%J¬	\Èn,Q¢D‰­F\ñ‘ÿ\æ\ï `m*Z\0\0\0\0IEND®B`‚'),(2,'logobueno',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\ñ\0\0`\0\0\0«@›\0\0\0 cHRM\0\0z%\0\0€ƒ\0\0ùÿ\0\0€\é\0\0u0\0\0\ê`\0\0:˜\0\0o’_\ÅF\0\0\0	pHYs\0\0\0\0\0šœ\0\0\'gIDATx^\í\İ?«.YV\Ç\ñy\r\ÃÀÁ\Èh\à\ÈŠ0—F“•N0\Í†= \n‚ù ˆbf:\ÜDÔÉ„L|\ÓM=Ì…w\İs×½ûü\î¯ş>µw\íªú¸½UµWU=]\ë©]\õ<\ç\0\0\à€l\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï ¶_ı\òƒ\Æ\Ìgƒ\0PS6\ğ’\æ\0˜fƒ\0P‹k\à%\Í0\Ì ×´]€gƒ\0°5×¬§\è:\0<gƒ\0°5×¤§|ı\ê“\ÇW_}üzq¿N\à\êl\0¶\ä\Z\ô\ÑÀ\õ\Ëoş­\ë@P™6f\õÿû6>D\×\\™\rÀ\\.ı\õ_ı\öã·¿ıkÿü¿k_£cWdƒ\0°\×|S4\îo~\ó›\ïü\Éÿ\Æ\â«\ò cWbƒ\0p+\×p\Óü\Ûw5\ğR\\3\Å\Ìcƒ\0p\×hS4h×¼KL±\ó\Ø \0\Ü\Â5\Ø\Ó\æ®q;L±\ãl\0\ÖrM5\ÅT¹k\ÖS˜b<€µ\\C\rs¦\Ñ\Ç0\Å|\È`\r\×D\ÓÚ«p\Å;\ğ\rÀ\Z®y†[¯Â¿øÁo2ÅË³A\0X\Ã5Î°\ÕU¸S\ì4s\\•\rÀR®Y¦%O¤¯\ëï»±\Ç\è6\0Gcƒ\0°”k’¡\ÆTú¦\Øq56\0K¹\ô\çU[`ŠWaƒ\0°”kŒ¡\æı\ğ1k¦\Øu›€\Ş\Ù \0,\á\Zbª}?|\Ê\Ò)v\İ6 g6\0K¸f˜\\c\İ\Ã\Ò)v\İF G6`\×”.s&n{CË‡\Ú\æXúC1º@olÀ4wÒŸK\×utn\ÃµÍ±\ä·\Øu[\Ø €a\îD¿–®û¨Ü¶…½j›c\ÉU¹n/\Ğ\à¹ütœ£q\Û\ö~¨m˜-pµ+\İf 6\àC\îÄ¾%\ï(Ü¶$\×4{4wz]·Ø›\rxÎ\ĞkÑ±{\ç¶!\ô\öPÛ”¹\Ó\ëºıÀlÀs\îd®¢Ä‹\Ä\ôlˆGL\Ã×¯>y|\õ\Õ\Ç\ÏbJ\Çï™«?\Ä\ö»f¹\Ä\Ã\Ã\Ã\ãıı½}m+\å\ñ7\Ëi\ä8\ğ;‰—¢aO\İû×³©?5\ğ¬Gi=\ZÛ-j‹\æzwwg_ÛŠc\Î}r\İÀlÀ{\î\âd_ü§D3e\æ\\\í­¥7®\æt„‡\Ú\Æ\Ğ\Èq6\à9wO1\ëšÀ˜¼2w\ëSZKO\\½\Ém\÷\Ñ\Ğ\È\Ñ;\ğœ;y§ømn\×\0\æ8úSÑ®\Ö\Û\ä¶\÷ˆh\ä\è™\rø;y‡[\àŠ«\ò£6rWg\Øâ¡¶L\İ/@+6\àC\î\ä\ÖL©—úT´«1\ôüKmk\Ì9>ºo€l€\çN\Şa\én\Î\Ñ\Z…«/¹\í;º©\ã£ûhÁx\î\än½\ZGjä®¶\õ»m;ƒ˜apÛœtµ\Ù \0Ï¸\ÓVS\ÈGhä®¦t¶©tu¤\ÙœŸ\r\æN\Üa\Ë+Ğ¹«%ù*<M=ˆ¨û¨\És\'\ît\Ë\×\ÍToS·®u\ôx™‹iu\ô\ÂŒs\'\î°\Ån¥©\ï(k]CÜ²[;\Û\×\Ê\Æ\ğzaƒ\0Æ¹w\Ú\â·´¦Y¸¼Ú¢\Æ-·ûø\ôÀŒs\'\ìT>\Ø\Ó\Ë1\Å\â\ß!šİ’†75u»·h\àW™F/\Å1tûcˆ¾‡€-\Ø €i\îD¢©]=§È‰)\èWuÑ¬³\áÇ¿Knù\Ä6¸wS³$C\ô}\Ü\ÂLs\'\è+\Ù\ò!¾£\Ùêƒ•¾§€¥lÀ<\î\Ä|f1k\r\Ì5¶+ˆ\Û±\Ê}³(k®È•¾·€9lÀ<\îd|&Ñ B\\u_\íÁ5¥²\Å\çk\Ù\Üi\æh\Í\Ì\ãNÂ½ˆ&W\ÍyŸ=¬Kù€S6¯«‹}U6\çh\Ös¹±\ïb¿\Ó\ÌÑŠ\r˜Ç|\÷\Â\ó\öt\ê|É­„h\ô[\\\ë{(\Ù €y\ÜI·%\ZwK®¾\çˆ\æK3\×\÷lÀ<î„›\âÄŸ\r6\Z@ˆÿz4ß¼J[rr/§\Èi\Üu\è\Õw\ìk—·F¼\Ö6t}\ïÁLs\'\Ú\'iwMY\Å	\íú°L4\Ø\òF3c\àr·\ã-½®\ïAÀLs\'Ù´\Õ\É?®c}4\ñºj^}\Ï\ã\Ím\æú>Äµ\Ù €i\î\â\êÙ¨\Ó\Ã\Ã\Ã\ãıı½}M­m\âK\ÆX\ëc\Ä\Õ\ğÿü\÷_>¾ú\ê\ã7û¹\Ö\Õ\÷\Ü\í˜\Û\Ì\õ½ˆ\ë²A\0\ãÜ‰5Ecp\'\è\'\ó»»;ûšZ\ÛÄ—Œ±\Ö\Ñ\Ç\È[O\rüEÕ«\ï¥\Û\Ó\ì\å{J\éû\×eƒ\0Æ¹kr\'\åµ\Ö6qŒ+§\Ïc\ßN}\ğ\ÚC~\È¢\ïI\\“\r\çNª!šƒ;!¯E\ßV4\ërºz\ëãµµ²V¥\ïI\\“\r\çNªa\ê~øR4\ñ\í\è•mW\ßjlZ]ß“¸&0ÎT\ÃÖ&¾#LŸ;e\İJß“¸&0ÌP\Ó\ÖO6\Ó\Äos´\ésUÖ®\ô}‰k²A\0\Ã\Ü	5¹\ñ-h\â\ëE/\ÍQ®¾S| ,\ëWú¾\Ä5\Ù €a\î„\Zj4Zšø:\åı\ï\ØwGk\à«p\Ìaƒ\0†¹“j¨1UK_®¼|´\é\ó\Ä\×\Ë0—\r\æNª!$v\'\ä[\Ğ\Ä\ç‹\é\ç34p¦Ñ±„\r\æN¬aë¯—šø<zÿ;\ö›\Ë;‚òƒˆ£\ïG\\›\r\æN¬&¾£?ÀV\ÒmQú^lÀsî„ª¢‰\ó³¶\Î\ğ\0[)¶!·\Ç\Ñ\÷%`ƒ\0¸\é˜8	G\ãİª™\ÓÄ‡\áşw‰‡Ù°†\rx\âN¦sl\Õ\Ìi\â\Ş\Ù\Z8\Ó\èX\Ë¬o\à¥h0·L\ñ\Ò\Ä?T6\ğ\Z\Ï!´6\õ4z\Ğ\÷&lÀwB]c\íıršø{±ÿ\Êû\Æ\åM¹M¾\'’\rxÏX\×Xs\ÕH¢\rü\è°¥<¾c\ôı”l€\çN²K,½\Z/O\ò\î\õ+\Ğ\é\æ³4p\İ.G\ß€²A\0;\Ñ.±¶‰_\õJ\\ø:KL£c6Às\'\Û\Ö\ÅK\îd>\æ\ÊM¼l\à±ıgj\à\ñ½¹m¾\ï€!6Às\'ÜM6N\ÎC\Í|\Í=\ñü\î\ğÕšø™8\÷Á±%\à¹n(›l4œ˜*-›ù\Ú?’M<\Ö\ç^?#m\à.\ç¨\Êm¢\ï9`Œ\r\ğ\ÜI75›¸¾\ô>x\éjMü\Ì\rœ\ÙPƒ\r\ğÜ‰7,i8\÷\÷\÷\ö5•\÷N—^\É/c­­\Çp\rüˆ\Û\á\Ä?ÿ\Ùw\ßmŸ£\ï5`à¹“oX\ÒÄ£a\Ü\İ\İ\Ù\×T>Á¼\ô~ú’1\Ö\ÚrŒ¡+\ğ£mÇ§ş\â\İ6:ú^\æ°A\0;ù†\ZS¿\å\ôk49—s\ÚÀÏ¶­SO¢}Ÿs\Ù \0Ï€C\í&\î^?ƒr\Ï\ØÀ\ó™†1ú–°A\0;	‡\Zı\ëego\à|•-\Ø \0ÏˆC&¾\ö~øœ½—·†\è{X\Ã¼\çNÀj\í\÷À‡”M.®\è\\\ÎQÅ¶E\ãm»jú>Ö°A\0O\Ü\ÉwH\\9Gƒr\'\ö¥\Î<•3\ál\r¼ü\ğ5F\ßgÀZ6`Y/\İ\Ú\Ì\ËFp¶©t\Z8\rÛ²A\0\ë›xŠi\ğ5Í¼|¢Ù½~T\åW­\Îx‹ ·mŒ¾Ç€[\Ù €Û›xXzU~Ö«\ğ\òƒ\É\Ùfh\àØ“\rx\âN\Æk\Ìm\ä9\İ|¦{\á\åW­bû\\\ÎQ\ÑÀ±7\ğ!wrkN\ó*Ÿj>\Ë\Õj¹M4p`{6\àC\î½„k¥ü\Ú\ÕYš]\Ù\ä\Î\ö”=\r½°A\0r\'\é\Íw\ÌT\Ëi\ô0w\ê½g4p\Z8Ú°A\0Ï¹“tŠ{\Ü\÷k\æc\Ó\ãg|j»üPr¦¯’•·\Æ\èû¨\Å<\çN\ÔA¯2£!k3›/ú:\Ë}\ğ\òC	\r¨\Ë<\çN\ÖÁ5\Ş8\ÙG<L5±løg¹~\Æ%^\Ù €\÷\Ü\É:\İr¥M.\×s¶û\àgùPh\à\è™\rxÏ°Ã­l\åz\Îp\Åz\Ö\ÙÊ™…1úZ±A\0ï¹“v¸\åj³¼\nw¯\Íd+\Ñ}¿\0-\Ù €\÷Ü‰;\ÜrM\ïW\áe³;K/\Î£\ï 5\ğÄ¸\Ó-\÷±sGoz\åı\â3| 	\å¬\Â}¯\0{°A\0\ã\rü–û¾\åıc\÷úQœ\ñA6\Z8\Æ+s\'m\'zZs5\Ó\ÏG\0,\Şd‹\ãH\Ç\Ù pU_¿ú\ä\ñ\ÕWÛ“·\'ş¥S\âÿù\ï?z3F\Üwu¯o\á\á\á\á\ñşşŞ¾¶…ø ’ûª\æ-\Ú\Û~ø\Ã\ï=şügßµ\ÇW\éûØ›\rW\õ\ÔÀ_|p\ò\ry\îUùS\ÃxQµ‰Gã»»»³¯\İ*\ïƒÇ¾úÛ¿ş›³•š\Û\â˜\Í=\æú^z`ƒÀU¹“\÷\\1­<\çª4§mø Xyü\è\Ó\è\åCyS\ô}\ô\Â+s\'\ñ%¦š\ó‘›xy\ßx\Í\ó\0½˜\ÛÀ\õ½\ô\Æ+s\'\ó¥\Æş\Z\ÙQ›øY~_aÃ™\Ø peî„¾T4j\×@\Â›x9>¶m½\ãG\\p66\\™;©§hq/Ø½V\Zkt\ÙHj>Ø¶µü\àq\äû\à¹\rS\ôı\0\ô\Ì+s\'\ö\r,\î§N5\ò±«\ì£5\ñØ–Ü®9\î\õ&fh\à8+®ÊØ“6\æø\ï¡f>\ö\ĞW6\Å#LK—\Ó\ècLz\õÏ™9	ú^\0À«r\'\÷04W¦\åU^ü{\êj5¬\ZZgOrÛP«šûz\Ğ\÷p6\\•;Á‡-¯B\Ò\Äs\Æ m\Z«°A\àŠ\Ü	>M/U6\÷z<^~ø£\Ç8\"®È\è\Ã\ÖW\ÌGh\âGF/omŒ\Ñc•\rW\áN\ğj\ë+Ñ²‰oy…¿•£N£\ÓÀqE6œ;¹ÙºÑ–SÕ½5\ñ#N£G\Í4p\\•\rg\çN\ğCbJy\Ëf\Ûs?\Ú4:°\á\êl83w‚Ÿ#®L·hº½\Ş?\Ú4:\r ‰\ã¢Ü‰~¸R½µ‘\÷ø³rv\à\Ó\è\å)z\ì3±A\à\n\Ü	[§×³\õ\ÔÄ4\Îıo\à=®Àøçº¥‘g\ï\å·Ó4N³A\à\n\Ü\É‰µ\Ó\ÎÙˆ\Ö.¿¥r\Z½\ç?\Èu\ÒÀ\Ù p®¤¸\Òv\ñR4\×p\Æ\ôv\ï9c\Ï\Ó\è<À³A\à\ì\\H\Ñ\\£qL5\ò5M¼œºv¯·T6\Çx\Ø\Î\å\ìŒ³A\à\ì\\H\Ù@¦¦p\×4¾ü[\âk>\0l©œØ»–!ùÿz|«°A\à\ì\\#nŠ;bzU¾f*¼§©\ôfœ²¾1z\\«±A\à\Ì\\3H?ü\á\÷\ï\ï\ï?h*1­W†\Ñ\\¢\ë\ësdcúú\Õ\'vŒ-=<<QNQ\ß\òablŒ[”³±¯^}\õ\ñ»ÿ.\éq®\È3s\r!DC‹¦twwg›\Ë-Ê«\ğ¿ÿ»ß¯2Fil;rV\áÖ‡\Ùj\ì+½}\ñ\ÔÀ_<‹=¦ÀU\Ù pV\ÚJk¯°\ç(§‡\İë­”u\Ä¹\Ë\Ù\Ë\Ø\ó%=¦À•\Ù pV®)„šw\õr/¼§{ò¥¨‹¬cƒÀ¹¦j^…gƒ\Úû»Ø½\ÔQ¢·±A\àŒ\\c5›Z/\Ó\×\å\Ãl½L£G\Ïû\óS\ôXxbƒÀÙ¸Æj5µ²q\îı“¦\Ù,k\Ş6X¢œ\Ú£\ÇÀs6œk¡\ÖUx\ÙÀ\÷nœ\ål@\Í\Ûs\ÑÀ\í\Ø p&®A¤\Z?7Z6\ğ½\ï?—\r³‡‡\Ùh\àÀ¶l8\×$B[6©½xÈŸy\í¡\Z8°=\Î\Â5‰´\õ•©6\ğ½ \ë\é*œ\ÔaƒÀY¸F‘¶nl\åW¸\önà¡—¯”\ÑÀzl8\×(\ÔVÍ¶ü®s\r¼ü`{\ÖC\ê²A\à\\³qe\Z\ò¿£Ñ¸4Wù\ôw\å\Ö\Èz\ö|2>\ökù\áfˆ7\0\ó\Ù pt®Y¤h´\Ñ`²‘\ß2­^^i\îı]\ğT~¨¸\õ\Ê-h\à@}6k¡¼?œ\Í.bk›]¹\÷zkå‡Š[>œÜŠ´aƒÀ‘¹†‘\Êû\Ãe\Ã[3\r\ŞK\Ã,e\ó\Ü\óCE~­mŒ3\0\ë\Ø pd®i\×Ø²á¬¹w\Ü\ÛUx|@\Ém\İ\ëCE\î“1z¼\0¬gƒÀQ¹¦‘\ÜS\Ú\åS\ÜK¦\Ô{¼\nQ\Ï^*\Ê}9D€\Û\Ø pD®i¤±+\íl~K¦\Ô{»\n/¯€\÷øJYù¡fˆ/\0·³A\àˆ\\\ãHcW\Ùk¦\Ôs½=\\…\ï=+0§=^\0ngƒÀÑ¸¦‘¦š\ó\Ò)\õ\òª×½\Ş\ÚŞ¿Ó\Ñ\ã`6kiNc^2¥¹=\\…\ïı0O¢û²A\àH\\\ãHs[^MFSr¯§²i\ÎùpP[~ \Ø\ã*œÙ€ı\Ù p$®y$\×|œ¹S\ê{6MUN\ë·~˜m\Î}p=N\0¶gƒÀQ¸æ‘–L/gSúú\Õ\'\ö§ß¶9\åUø-M\ó\á\á\á\ñşşŞ¾6W\ÙD\İvn1Æ;>\ÄÄ¾z\õ\Õ\Ç\ï\ê(\éqP‡\rG\á\ZHXs¥\ËDSú—ú½Á\×c\İKbw¢¹\Ş\İ\İ\Ù\×\æ\Ê\éÿ¡\í\ÜbŒ!9\öS\ñ\æ\ß%=F\0\ê±A\à´y”\Ö<\äUNO\ë”ú\Øk­•Sÿ­§Ñ¹\ô\ÅŞ¹\æ‘\Ö\\…§\òj;›uÙ¸\Ö|8\ØR9~\ëŒÀR\å\ØC\ô8¨\ËŞ¹’n¹:-¯¸£I–_¡j\İ4²>\÷zM9>D€úl\è™k i‹F[6\Ê-\×{«\òÁº\Ö3nŸ”\ôh\Ã¹&’¶º_\r3¯\Ä[\ßw’Sı·\Ü.X£ü\ğ0D€6l\è•k ©\õ\ÕiK\å•p\Ë\ë¸\ô\Í^¹&’\\:ƒ=§Ñ¹\ô\Í¹&’\Î|¾\×4:_\'úgƒ@o\\I­›[KL£cƒ@o\\Iq\Å\è\Z\Ñ\Ñ1`Š\r=qM$\õ*¼¼n½\åÕ¿£\ÇÀ~l\è‰k$©\åsK\å•p\Ëm\ä\ëdÀ±\Ø \Ğ\×D\ÒYf\Û\ëg^¹\r=pM$]a\Z½\õ¯\Äq8\ö\æšH\é¬W\á\ÙH{»\ôØŸ\r{q\ÍC\õ*¼l¤-\ê•it\à¸lh\Í5!-\\+{~,>•ûW\é±\ĞZrc\È¿^^	·e\à>8pl6´\àšÆhng¼\å}\ğ–_\'\ãgU\ã³A 6\×0†ÄŸuM\èb\Ûr;¹`)jq\ÍbÈ™¯¾\ßp+¶\æ\ZÅ˜3_}‡\òA6¾`-¶\âšÄ˜³_}‡=d\ãû\àÀ¹\Ø p+\×¦LM)?<<<\Ş\ß\ß\Û×¶R{Œh\à_¿ú\ä\ñ\ÕWWm\àn;Ê«ÿ!z\ô\Í5~\õ\Ë¶1L‰\é\İ9OeGSº»»³¯m¥\æy\r<\öU\Í\İ\îƒ\çdƒÀR®)L¹\Â\Ôy\Ò&\Úz»¹œ“\rs¹†0\Ç´eH\ï\r<\èqp6ŒqM`®³?u®\ön\à\å\÷Ğ‡\è\ñp68®\Ì\Í$\Zšk4gµw\çÙ€\ó³A \äNşs\ÅT\îU\î{—\ön\à1^9¾£\ÇÀ\ñ\Ø \Ü\É¸\ò¾b\ó4p\0­\Ø \Ü\É\Ê§\ÍK\Ú@[7pı\01D5€c²A ¸“ÿø¡–+7\ïP>¾\Ç\×\çbÿ\ó$:p-6¸“¿º\ò”yI›gü{44p\àzlp\r ]\é;\ŞStú<\Z©Ë«\\“\r\â\Ú\\H4\ğ\÷´q\îµoh\àÀu\Ù ®\Í5\Ğú/n\õJ§\Ï\÷üùX\Z8pm6ˆ\ërM Mı•±+\Ğ?\å\Ï¸¼h\à\0l\×\å\ZAr\ä*\âJ;®¸s_\ìı\Ç[h\à\0‚\r\âº\\3\Ñ4\\39;\÷µ­=¯¾\r@²A\\—k\áŠS\é:u\Ís\ï¯\Ô\ÑÀ”l\×\åšB\Ø\ã{\Ï{q8d\ï\æh\à\0”\r\âš\\SHWh\âÑ¼\ËûŞ¡‡7¥\ï\è\ñp~6ˆ\ër\Í!œµ‰\Çv\Å=n\İ\Ş^~>f\0´¶!z,œŸ\r\âº\\sq%Wªgi\æ±-\îê¶—\æh\à\0¦\Ø ®\Ë5ˆR4¾˜bs¤†M;\Z´N—§\Ş> D=®NG!€\ë°A\\—kS¢±gs\æ³gƒq£†¨e¬i‡x½‡Ö”›!p\ô\Ø¸\Äu¹f‘²9F“k¥l\ğ\Ñ0cÙ²\Ñg³Oe#+\ã¥X&–/\õT³.\õÚ¸C\ÔE°„\r\â\Ú\\\Ó\Ñ(£‘–M\'D3ı\Ïÿ\Ñ\ã\Ï\ö\İ\Ù\Ít¯_}\òøê«\ík*?8d\Ã/\ë\ó\ğ\ğ\ğxo_ÛŠ#\ö¡\ÛG€\ë²A\\›k)šM\Ù|R4¥»»»wÿ]6øh¦yEM~m£j\à/Ş­#u6\ëon³¢\ÛQC9F\Ô;\÷\ê;\è±pm6¸’¢ajcZ#\ZX)*_s\Ë]l£Û¿C\ô€\r®‰”†®\È1O\Ì¸ı:D\0‚k&%\Zùr1‹\á\ö\å=&\0P²A ¸¦¢¢‘Ÿuº{KÑ¼—> \Ç\0”\r\É5f\Åı]×¼®.\öË’×‚\0bƒ@\É5\Z\'\î\órUş$\ö\Ã\Ò\æt\ßÀ”k8C®\Ü\Ì\×L›\'\İ\ç\00\Å\Ç51q%\ZM\í\ì\r=¶q\ÍUw\Òı\0s\Ù 0\Ä5¡9¢\É\ÅCpùıo\× j¦?b\ã¶u.İ·\0°”\rS\\SZ\"šz4Ál\ì½4\÷¨!\ë‰f¢ÎµS\ä\îK\0X\Ë9\\ƒ\ÚBş¤jŠ&ZŠÆ¯4G•\ëK1NruÔ û\0naƒÀ®Y\á9\İg\0°\Öp\Í\ë\Êtÿ\0À\Öl¸…khW¢û\0j±A`+®É‘n7\0´`ƒ@-®n\0\ì\Å–\\£\ì\Ö	\0½±A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?\0\0ı³A\0\0\Ğ?l\å¿ø\Åc-:\ÖRn{\Ó\Z“\ËMšÛŠ«%in/\\­µi\r[qcmA\Çi\ÍÕ´§7\î´®9\Üzz¥µ/\å\ÖY›Ö°„\r\Ö\ä6 {·^h­\É\å&\Ím\ÅÕ’4wO®¾–´[¸\õ×¤\ã\×\äÆ¯A\Çİ‚§Z\ç·|¯´\ö9\ÜzZ\Òz–°Á­¹¢[\ÑZ¦¸u\ôBkM.7in+®–¤¹{pu\íA\ëZÃ­·%­gKn¼´µÜº{¢\õq\Ë\öJk\ã–ßƒÖµ„\rn\ÅÛš\Ö4\Æ-\ß­7¹Ü¤¹­¸Z’\æ¶\æjÚ‹Ö¶”[\ç´®[¹1ZÓš\Öp\ë\í\Ö\ì¸\åz¥µq\Ë\îEk[\Â·\à\nİƒ\Ö5\Æ-\ß­7¹Ü¤¹­¸Z’\æ¶\ä\êÙ“Ö·„[ß´¾µÜº\÷¢µ-\å\Ö\Ù#­[¹ez¥µ;n¹=i}K\Ø\à-\\{\ÒúÆ¸\å{¢\õ&—›4·WK\Ò\ÜV\\-{\Ó\Z\çr\ë\êÖ¹”[\çŞ´\Æ%\Üúz¤u+·L¯´v\å–Ù›Ö¸„\r®\åŠÛ›\Ö8\Æ-\ß­7¹Ü¤¹­¸Z’\æ¶\à\ê\è\Ö9‡[OO´Ş¹Üº&¼¼‘[§¥µ\Î\å\Ö\Õ+­½\ä\ò{¤u+·L´\Î%lp\rWØˆ/Â§Ÿ~ú_\á\'?ù\É\ß\ÜB\ÖıŒ\Ö9\Æ-Ÿ4·\'®Ş¤¹­¸Z’\æ\Ö\æj(i~\ï\Ü6$Í­Å]\Òü)n\Æ\Ë\×\ç‹ø\ñü\Çá£>ú–[\×\ßÿş\÷¿ıú\Ü\ñƒŸş\ô§\ë•q,]\Çn=Is[qµÍ«Á4¯7v\ÒÜ£°Á¥\Ü\ğ¦q¿ş\ğ\Ï\İz\Öxı?\ò¯›q\Ş\Ñü1nù¤¹=q\õ&\Ím\ÅÕ’4·6WC\Ò\Ü#p\Û4¯6WC\Ò\Ü)n\âe4n·ì­¢¡Ç‡ƒC\Æü€.;Å­#in+®–¤¹[scÍ«Á›4\÷Hlp)·S\Ä¯?\ñşk4\\·ü-h\â}\Ö\íjIš[›«!h\Ş¸\íHšÛ‚«#i\î·l\á\Í\Õ\÷-W\İsÅ‡„O\ÆF—™\âÖ‘4·WK\ÒÜ­¹1ƒ\æ\Õ\à\ÆMš{$6¸„\Û!\â‹-¯¼M¼Ïº]-Iskr\ã\'\Í=·Is[pu$\Í\â–-¼t\Ë\ÔS\ì1¦\Ô\ğŒ.3\Æ-Ÿ4·WK\ÒÜ­¹1ƒ\æ\Õ\à\Æ\ršw468—\Û!¥˜:¯q\õ]¢‰\÷Y·«%inMnü¤¹G\à¶#in+®– y[®\ğ²\Å¸Šq¥g4Œ[>in+®–¤¹[sc\ÍÛš3i\î\Ñ\Ø\à\\n‡¾¨\İÀM¼Ïº]-Iskr\ã\'\Í=·Is[qµ$\ÍUn™·^\ÆCgn™\Ú\âyŒ/\õ<£\Ëq\Ë&\Ím\ÅÕ’4wknÌ y[sc&\Í=\Zœ\Ã\íŒB\Õ)\ôM¼Ïº]-Iskr\ã\'\Í=·Is[qµ$\ÍUn™·šN£«·O­»º\Ş\Ğü!nÙ¤¹­¸Z’\ænÍ4oknÌ¤¹Gcƒs¸‘b\Z\İ-SM¼Ïº]-A\ójs5$\Í=·Is[qµ$\Í-¹üM¼WK\ÒÜ­¹1ƒ\æmÍ™4\÷hlp·3\Şj2h\â}\Ö\íj	š×‚«#h\Ş¸\íHšÛŠ«%in\Éå§½¦\Ò\Ó\Û\'\ÕmmA\ó‡¸e“\æ¶\âj	šWƒ7h^\rnÜ yGcƒSÜ(|á–©…&\Şgİ®– y-¸:’\æ\ö\ÎmC\Ò\ÜV\\-IsK.?\ÅS\ân™V^ŸW¾\õºÁû\âš?\Ä-›4·WKĞ¼\ZÜ¸A\ójp\ã&\Í=œ\âvBŠ_P{xxø[nK9F\Í&ş\å—_>~şù\ç‹\×Óš\Ö]\Ò\ÜV\\-A\óZpu$\Í\íÛ†¤¹­¸Z’\æ–\\~Š‡\Ë\"\ç\õÿç¿¥\ËmmhŒ\×ul\Ö\Ä\Ës\É\Òul­¬¡¤y5¸qƒ\æ\ÕP\×\Ó\ñ¸•\rN)7\\|\ñú¾?t\Ë\ÔR³‰\ÇAş\ì³\Ï¯gZ{Isks5$\Ím\Å\Õ\â\Ä1\×e{\âjNšÛŠ«%in\É\å§l\â{z]\ÇfM¼<—,]Ç–\Ê\ñ•\æ\Ö\à\Æ\ršWK\çGI—\ë™\rNqıVÓ©\ô°\çtº\ËÛ’7\Æ-Ÿ4·6WC\Ò\ÜV\\-­iMk¸\õ&\Ím\ÅÕ’4·\ä\ò\ÓÙš¸£¹-¸:’\æ\Ö\à\Æ\ršW“¿%­\çV68\Å\öM|C:\Ş·|I\ókqc\'\Ím\ÍÕ´­k	·¾¤¹­¸Z‚\æ)·L¢‰o\ÏÕ4·7vĞ¼š\Üø{ĞºÖ²Á)® ·h\â\Ò\ñ¦¸u”4Kn<¥\Ë\ìÁÕµ­m·¤¹­¸Z‚\æ)·L¢‰oÇ­t™Z\Ü\ØA\ójs5\ìEk[\Ê§¸BŞ¢‰oHÇ›Ã­§Z\ç\\}{\ÑÚ¦¸u$\ÍmÁÕ‘4W¹e\ÒU›¸Ë«Mk¨É4¯W\Ç^´¶%lpŠ+\â-šø†t¼9\Üz\ö¦5\ö\ÂÕº­kŒ[>in®¤¹\Ê-“®\Ø\Ä]NmZCm®† y-¹z\ö u\ÍeƒS\\o\Ñ\Ä7¤\ã\Í\åÖµ­­G®\îÖ´¦!nÙ¤¹µ¹\Z’\æ:n¹D¯O\ÇoÁ\Õ4o®®Ö´¦9lpŠü­/\â{\â-\Å\ß)7u¼£µq\Ë\'\Í\íÛ†Ö´¦«rûF\é2CÜ²Iskqc+]\Æq\Ë%šx}:~® yg\ä¶[\é2s\Ø\à7x¯´\ö1nù¤¹Gá¶¥­OÜ¾Jš\ë¸\å’\æ—W›\Ö0\Ä-›\âgO\İ2-½®\ã”M\\\Çm\É\Õ4\ï\ì\Ü>Hš;\Å§¸{¥µq\Ë\'\Í=\Z·M5\è¸x\Î\í³¤¹[.inpy5\éøc\Ü\ò\é\';ÿ\ìj\Ì¼®\ãTM\\\ÇÛƒ«+h\ŞÙ¹}4wŠ\rNq\÷Jk\ã–Oš{dnûn¡\ë\Ç8·“\æ*·L\Ò\Ü\à\òjÑ±§¸u¤½ÿ\0\Ê\Û&nkš?\Ä-›–ä®¥c\ì\Í\Õ4\ï\n\Ü~Hš;\Æ§¸A{¥µq\Ë\'\Í=#·\İIs±Û¿Is•[&inpy5\è¸s¸\õ¤O?ı\ô\Ü2­\ÄL€«+iş·l\Ò\Ü1nù!ºlO\\½A\ó®Àí‡¤¹clpŠ´WZû·|\Ò\Ü3rÛ4\ë¹ı›4W¹e’\æ—·5s	·¾·^~\ô\ÑG\ßrË´\"LM\ïhş·l\Ò\Ü)n.\×WoĞ¼+pû!i\îœ\â\í•\Ö>\Æ-Ÿ4\÷Œ\Üv\'\Í\Åznÿ&\ÍUn™¤¹Á\åmE\ÇZÃ­7\íu_|«û\áÁ-Ÿ4w·¥\Ë\ô\Ä\Õ4\ï\n\Ü~Hš;\Æ§¸A{¥µq\Ë\'\Í=#·\İIs±Û¿Is•[&inpy·\Ğ\õ\ßÊQx¹\ÇW\Íb\\©\ã\Í\ã–Oš»„[Ÿ\Òez\à\êšwn?$\ÍcƒSÜ A\óZqµ$\Í\ã–Oš{Fn»“\æb=·“\æ*·L\ÒÜ£pÛ’Z\ß\ê^\Û}nJ—Ù›«1h\Ş¸ı4wŒ\rNqƒ\Ík\ÅÕ’4wŒ[>i\î¹\íNš‹\õ\Üş\rš\ç¸\å’\æ…Û–\Â\ËV<¾›\ã\Éø\Ï\è2S\Ü:’\æ®\áÖ«t™=¹ú‚\æ]\ÛA\ó¦\Ø\à7pĞ¼V\\-IsÇ¸\å“æ‘\Ûî¤¹X\Ç\íÛ¤¹[.iî‘¸\í)¼i\äµ~\0& ‹1\Şrã¿£\ËNq\ëHš»–[·\Òe\ö\âjšwvn$ÍbƒS\ÜÀA\óZqµ$\Í\ã–Oš{Fn»“\æb9·_Kš\ï¸\å’\æ‰\Û\ãM3\Ş\â^ù-O¯\Ç\ò\ñ¡\à\íS\è“\Í;\è:\æp\ëIš{·~¥\Ë\ìÁ\Õ4\ï\Ì\Ü\ö—4Š\rNq\Ík\ÅÕ’4wŒ[>i\î¹\íNš{$n{z£5q\Ë&\Í=\Z·M\ò\êy-·NKkË­+i\î­\ÜJ—i\Í\Õ4¯7no´\æ9lpŠ<h^+®–¤¹c\Ü\òIs\Ï\Èmw\Ò\Ü#q\Û\Ó­yˆ[6i\î¹\í\ê\Ö9—[W\ÒÜ­¸±”.ÓŠ«%h^\rn\Ü\Şh\Ís\Ø\à7xĞ¼V\\-IsÇ¸\å“æ‘\Ûî¤¹Gâ¶§\'Z\ï·|\ÒÜ£rÛ¶\'­o	·¾¤¹[r\ã)]¦WGĞ¼\ZÜ¸=\Ñz\ç²Á)®€ y­¸Z’\æq\Ë\'\Í=#·\İIs\ÄmO/´\Ö)nIs\Ìm_kZ\Ó\Zn½Is·\æ\ÆTºLm®† y5¸q{¡µ.aƒS\\A\óZqµ$\Í\ã–Oš{Fn»“\æ‰Û½is¹u%\Í=·-hk¹u\'Í­Á«t™š\ÜøA\ójp\ã\îMk\\\Ã§¸b‚\æµ\âjIš;F—ı\ò\Ë/?ÿü\ó\Å\ë9*\İş’\æ‰Û!\å1¯E\ë[Â­/i\îY\Ô>5ÿ?wc$Í­¥sˆ.S‹;h^\r\åx-ş?Ck»…\rNqE\Ík\ÅÕ’4wŒ.\à³\Ï>[¼£\Ò\í/iî‘¸\íR\ó-iMk¹u\'\Í=#·İ·Šc®\ãl¥C\ßWš[S9\î]¦7nĞ¼\Z\Ê\ñjı^ju\Ìm\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\Ï\0@ÿl\0\0\ô\î\ñÿyÁ‹T\0\0\0\0IEND®B`‚'),(3,'lk',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\0\Ã\0\0\0n\0\0\0šı§š\0\0\0 cHRM\0\0z&\0\0€„\0\0ú\0\0\0€\è\0\0u0\0\0\ê`\0\0:˜\0\0pœºQ<\0\0\0gAMA\0\0±üa\0\0\0	pHYs\0\0\0\0\0šœ\0\0£IDATx^\í_lU\Ç\Ù\İ\Ä}\ñ‰\ì6DEDÿPÿ Rü\nTDPAQJQ«hA[ÀŠ¶hU M·å°AKaQLƒ£@p\×P_$›\ZÖ¸11\Ën6³\ç{ù]\î\í½¿3wÎ™3s\çv~Ÿ\ä¯eÎ™93\ó\óÿœ!‚ ‚ ‚/‹/\ö\æÍ›\ç-]ºÔ£?	B:¹\÷\Ş{½©S§z?ü°˜AH7bA \Ä‚@ˆ3q\Ûm·91\Ã_|1š~†¢¿¿ÿ\\ú\Z\×9\ô3*\á\ô3G™L?Cqø\ğa\'\ñ¨t¤Ÿ¡puŸ«\ç¯\ŞG\ó´Íœ9SrA\0RLB\Ì „˜A1ƒ bA *\Å\ï¿ÿ~}WW\×7&ÚºukŸ\Ëf?v\í\Ú\õ\ZwmI\Ô\æÍ›\÷«ûu\î\îwŒŸ†’;Ÿ}\öÙ„7å®‹Sww\÷W}}}\Íü•b†šš\ZoÌ˜1Fº\ò\Ê+=$š¢(\÷\ß?{mI\Ô\r7\Ü\à©¤fxü\ñ\Ç\Ùcü4a\Â\ï•W^9MI¼¿cÇe¯‹\Ó\ÕW_\ímÚ´\é?C%˜\á½\÷\Şk\âDs\æ\Ì\ñ\Ô\ÃuÒ¹dC%š×½oß¾3f\Ì`\ó\ÓM7İ„û\í¤“2(\È}q\í\Ü\õ\èt\ß}\÷¿\ï•`†x€MP?\ŞÛ¶m[E;•j\ğú\ë¯ÿ\ó\Úk¯e\õÓ“O>Û»„b\İC=\ä]~ù\å\ìµpº\ì²Ë¼w\Şy\ç5Š\"G\ÒÍ€¡W\\q›¨ ª­­-[\Ú*\Ù\ÈQm>Dx^q}€^z\é¥Lq˜»\Z\Z\Zø\÷!\éf¨««cd\"<\öK•l\Ğ\Ù\Ùù\Í5\×\\\Ãï§¹sç¢¸\älœÇ={\Z¦L™Â_§o¼Qÿ\'\Ù}\ôQÍƒ\àT___–\ôUºÀƒ>\È\ï\'|­[ZZ\"½\ç\Ï=\÷œQ¥\òÍ±’l†eË–•ı„/‚úR\r¥¨cc0˜Í–Ó¦MË”µ¹p:\İr\Ë-«\ÑÌ…\ô\ô\ôì¬ªªbÏ«\çIª\ÔMw\ó\Í7³‰²Õ¢E‹bO\ã`0@eúª«®b\Ã\é4n\Ü8\ï‰\'p~\Ïa0Ã¸sê„†\0´Q<I5n>Ú‚¹„\Ùj\âÄ‰bù™Ìš5‹\r\ç\'\ÄYÔ’¶¶¶\ÓÜ¹t‚)W¯^]ú\Ù\'\Õ¸..aa\è¦8\Ä\Æ¨\ğ\ãÅ‹[,\ğT=m]zh„0-£\ãED¼\È\é)šP8p`vuu5{.\Ğ\×¨¸v\Çw81ƒË–8ÿº\ë®cT£F\ò.¾øâ¢¿û¶&hPi³Ò‘o†/¼pÀµpB¹|ú\ô\éf\Å\é„/\í\'Ÿ|2•û7¡2‰¢C\öÿQ7 \Ë\Ö\ò\È#]3\î\ó%—\\R\ô\÷¬\Ğ3½v\í\Ú(ŠP<\ó\Ì3\ì9\ò5z\ôho\äÈ‘™ß¨WÎ™P1rd\'c€\ğ“h*<\Î¨c.rlÌ€/)gQ\÷zıŒƒNE\Å8ÿšK™ºë®»<˜¢±b\çÎA\ê-0\ÃE]”ù\r\ón8IZ1Ie\Å¦\Ù\à”)S~š}\ãeÃƒ¡\ÓEi1)ˆ\ÊM{{ûI\î\Úı„â’¶³+ (\Åpq\ëtë­·zªAÁK“43 4)—ª\ëşµ««kI/$ú.v\ìØ±…N)ƒ\Ñ(\Û\Ô\é\ğ‘\ë\í\íµº\ïË—/g\ã\Ô	\ÃpV®\\iv“d†?üp®…KœNo¿ı\öf\ÑT¹\ô{\î\ß9\á+µdÉ’X\Ò;\Í\0\ğ1\á®\ßOø\ÈQÏ´QŠ…¦Íº\ÈıU‘\Ûl€f’Ì€q&&¹\Æ\Í|û\í·c\öù\çŸo\ä\ÑiÒ¤I\È\ÖgN!ƒ\Õ`ÅŠl\Zü„\ç»f\Í\Z£\Ê4\âqq\é„&ùW_}\õ\nœ¤˜-p3—8N¸©6lør\êÔ©¡\ê‹ÿw,\'d£MMM‘§y0›-Qw\Şy\'›?¡\ï!\èW{Ë–-{Mr\Ü?¼\ÓÜŒ¤˜‰\æ§?;r\ä\È\n¡¾¾¾…;V\'Œ\×?t\èP\r„Ál\Ğ\Ñ\Ñq\Òt\Ô(„˜…§L‹\Í0\ZŠ\Û…I0ƒJ\ôpÓ™l---\ß{7 9\÷À¨ªª\nœ; s«µµ5\Òtv3\à\Ù\Ù\ä»şú\ë½R\ÓDQ65\Z*\ÚÜœ$˜Í©\\\ÂtB‡\\___€\Ê^\ã\Âè„Z\õNZ2\Ø\Í\0\ğR£3“KŸn¿ıvm:\÷\ï\ß?ÿÎ…\Ó	³\ì(¸I0×«é§…V¹\Âo)ø\0¶o\ß>£z(1fŸ‚;\'\rf\0\Ï>û¬\ñW\ÒÍ™~ê©§2­~\\B\Ïw/·0¿Ù¤‚¤^\Şÿtuu¢\àE(“ü¦ººÚ¨S/¬q3\\@\Òb|\É1šK“Ÿ&OŒ\ñP\êm¨?bP%w¼NhY¤\à\ö”\Û\â\Ë%N§Y³fı•‚jYµjUV\'TºJ•_mI‹\0¾\ò‡Ä¥K\'|ı‘P™\á8˜¬\Ï«†gc\0EaO9Í€Áa¦7¯¡¡a:\×r\ğ\àÁ±…\ãgü„\ñJ>úh$\Ó\Ód´ş˜™@zQ\ÖGn€80 \rÜ±:½ü\ò\Ën\îW9\Í\Ğ\Ü\Ü\Ì&N\'UIû×={~OÁ}Q¦9ÁÅ¡:\á\Â$\ãH“\0†y›\Î@Cš‘lØ°\á(\Æq\Ç\è„w¹	>\å4:¾¸\êT[[»™‚–dÓ¦M+q“¹x8\á\Ø(\æ:Ø˜X.–\×]€ù\æ&\÷B\'*r\Óg\ætr¹Ì€6d.:¡\énû\ö\í“(xIT–=L½ˆ¿rqé„¶o\×Í¬¦fˆ[X9.\Õ\êŞŸgZü5Œ€\õ™Ô¹\Ü-Z.3\à\Å\ã©ÓŒ3~\ô<\ïw<\ëLs\æwB\Z\Í\006ˆ;Ÿ+¡Nˆ\õw\étnÀØ’¸\Í\ğ\æ›o\î\Ô5§b’&g\äÿ\r-Ë–-û3Œª_ü±¦¦\Æh¾,\î*‚Eh\ò\ÍÀM6²‘«x0\ğ±\Ç‹\ì¹c\Æw^\ğ\ÜKM‚PœŠd\ZWª(p;=r#]\Ù\Ó\õ\ğ\òÿ†6\ç/¿ür\"7¢±±±\Ût¹™\Â)Š*m\Ök‡f\Ípé¥—z#FŒ(:—\Î?ÿ|\öï¦º\à‚¼Å‹‡~©tET¦MJ\0x\î\Ù\éš~Bª\Ô&&\ï\ãY\â.&a¼\É\r‚i.\\øƒ®Ç¹o½\õÖŸª««ÿ\ËÅ­\ÆIQ\ğĞ¤µ˜”\å\Å_d\Ïk+Å‰l\Ä@\ÜfÀ\Í7\éfG+\Ã\îİ»\Û)¸\ó\ç\Ïÿ·N\ïjy“´›Í¦cŒtBd´«5qšCkM\×\ÆDæ§Ÿ~ª¢(¬X½z\õUGù¿Nx‰)x(\Òn€5°¸s›\n}A\Î+\Íù\Äi\Ìd3m\İ\é\î\î>…\ñF…5Ó¦M\ë\å\â\×	Mƒ\ê\ÆÛ‹\ÏC\Ìp¦Î¥Šº\ìùƒ\n\ï\rŠ\\e4\Äe†?şx¶\Í\î;û\ö\íû\÷\ñ\ã\Çÿ¡tL\é\ï~:v\ì\ØQ\õ\ß\n\õù\çŸP[[{Ü¤\"º\n†h\Ğ\å[#f8\Æ~™®z’/\Ô3uug\Äe†¶¶¶_L\æ7g…&X”\á\ÃÊ´E	BG_\ØZ3ÀˆøÆ¡87y\á…´­ˆ~B˜7\Şx#úµ®\â0ƒrtfw.¡I¶\Ş\ÆXpE´8„\n.]j\ä`Î´\Í0oLÏ¥(¢%3À\Õø:s	Mº\Ğd\ÙE¦fÀW°’\êù¢\ÍN@¨€S\Ñµ\Ô\rŠ¸¹DV‚PLSq3\äH½lvbLš°BµmqBÌ#\õf@K`%	\ÃA¶ZÎ„3\äHµ°Ö¿\ÍÖ©I*Ò¶­.b†©6ƒéœ…$½ŸF+:b†©5ƒJø¹ƒ!W\È\n}$\Æ\÷HÌ#µf0].²d36FÌ#µf0YÂ—M˜ê†‡°Æª\ÉB\Ç^TÓ•\Ä9\Ô}O¶fÏ\í\ÜX\å€K”Ÿ`\Ê8{Cn2w-ùÂ¤œü™w˜e²ŠF¾\ng\ğqJ³\n\ïuV±™+š¹0\öú¢ŸCfÎœY” ?aŒÆ­ ¬ºaÖ³\Ê\nÁÍ§Ÿ,XÍ¯Ô’ˆ˜†X8³\ã¬(Š’dÍ€=|ø\ğ\ñp\nbÓ¢š¬[E?CQ\ê>g)e\ì\Ã\Æ\í{gc«e\\“\Ğ\âR˜˜R\Â\ÂSX¢ˆ\r\õp†ÚŒ™\ÂŒ*l M¥˜”£”tª\Ø:ƒ\éÒ€¨+”c\çş,\èL3]\ô\ns‚Î„3\äH•\ğu7}±0Nİ¶w\×ª2\Ë\Òs\×\æ\'Ôµ(\n_\Ä9ReL17\àr\ò½-¨¯p\×\æ\'\à\ÃhŠB‹˜!GjÌ€2´\éüf¬ùT¾\0¼ûî»­˜CÀ]£Ÿ°c\rE¡EÌ#5fÀräº…ÁtÂ²®Z4Â‚eÑ¹k\ôZÁT1\Ëw9J1CT˜A%rø\İwßy\\b8\áØ¸\æ\ß=\æ¦K^BO?ı´o\Z\Ä9Rat²\á+\Ï%D\'´\")sÇ‰M3+rC¿\ÜAÌ#fÀ…x)L„9<1`¨®‹»^\Ğ\Ì\ê\÷°jkk\Ùp:azl9›š£D™a–Œ\á\Ò\í\'\ÓMÔ­	k$pıú\õ_ao\õ\ö\ön¡(ƒJ\Ë9\Ø$»^` Eh6\æ\Â\é„ø’xo\\´q\é\ö\ÓŞ½{(x´¸ª@B\Å#fB\Ì „˜A1ƒ bA \Ä‚@`¥ifpÕ›f]\Ó|úûû\Ï-5n((®&a3ú\nOı¦Ÿ¡Àt]\Üoú_k\Ğ\Ï\ã\êùccú\Épi|!0\Z_¬>\ñé§Ÿ²;t\â€\ãpLV8Vı\İw.-S\ç0\ß\ÅQ‚\à\Â0Á\ò\å\Ë=Œ\\E|\ğ†YXŠ¥µµµ(\Ş5k\Öü{c\á\0aq_\ìß¶d\É»üĞ¡gA6Œ\ë\\ºt)\æ‡Î’¡fXµjU&X\ë\ë\ëk\Å\Z«XÁ¡££\ã$7¥3k\ì\ñ¶{\÷îŒ¶mÛ–Y!c\îÜ¹™\rB\n\Ëûb!rÂšA½˜C1¦¹\0~ÓŸ}°Ë®]»~¥?eø\î»\ï2†À\õn[$f\"\ÇEÎ€\"\æ2m™g†¢s\"‡@‘©p:¨˜AˆfPE£fo°L–nooo?‰º\ÔK\Ë\îÎ¨3\Ã\Ï?ÿì©¢Uf¯\Î\Î\Î\ô\çb!r\\˜`³¶¶¶\Ó\ó\ç\ÏÏ¼Ìˆ[\Ç\îØ±£(·\È\Ö6n\Ü\è8q\Âûú\ë¯1f\İ[·n]f	¨°½Y\Ì D+3\ä£^Ö‘X‚›¢e©°s\'k´&\İs\Ï=™\êPç€‰p<šP\éĞ³ˆ„È‰\ÂYP‡À¯r‡\õ\ô§Y3`ºhWW\×7\êø\ÛÚµk\Ù)~b!r\\˜/{\á\æ\á\ê…\Ú\ÜÜœyÁ§Ef\ë…\Ã\ĞÔŠœ‚Ú‘5\ê$º\Î<AEX3¨—\ô<lW…%\Z1‘½©©	«TŸ®««\Ët¢­X±_\ò+k\ëÌ€^i\äPaOs\Öhµ\Â\ê\è‹\ÈŒG‡\n‚.r\é\ÑÛŒ—\ÂW^U\â%¦\ÃÎ‚9\Ë- †V(„\å‘¡¹U\'¬{D‡	‚Q\Ö¡¢3!fB\Ì Duuµ3pÃ®m(­\Z†\ÂV,[¬\öcpµ2\Z\èg(\ò\÷\áƒ«ûT\\N\æ«6\õ½¿’3‚BŠI‚@ˆ3!fB\Ì „˜Al³„%^04šş$é¤¿¿:M”­l!ƒ‹!Cş\Ú¡üi\0\0\0\0IEND®B`‚'),(4,'mn',_binary '‰PNG\r\n\Z\n\0\0\0\rIHDR\0\0\ñ\0\0`\0\0\0«@›\0\0\0sRGB\0®\Î\é\0\0\0gAMA\0\0±üa\0\0*bIDATx^\í\İO«%É\Şq¿}Z¦|\ÄØ ‘\Æ\ËmaP!<\õr†³\Ğ\Â\êY´i\r¯F¿i5ŒG µÀ¼\ñ+P\÷ª\İ\ôúZOÕRT\Ô/3~‘‘ù]|\èª:\'3\"#2\ãÉˆ\Ì{û\ï}\ík_{\0\0\ã!\Ä\0!\0À q\0\0Eˆ\00(B\0€A\â\0\0Š\0`P„8\0\0ƒ\"\Ä\0!\0À q\0\0\Õ$\Ä\Ç\Óı~7?«…2ü(Ã2ü(Ã2ü(\ÃOe4	qUüv»™Ÿ\ÕB~”\áG~”\áG~”\á§2XN\0`P„8\0\0ƒ\"\Ä\0!\0À q\0\0Eˆ\00(B\0€A\â\0\0Š\0`P„8\0\0ƒ\"\Ä\0!\0À q\0\0Eˆ\00(B\0€A\â\0\0Š\0`P„8€\Ã}\ç_ı\Ñ\ÓO~üŸş\ëù“§ÿ\ğ\ï\îOü\ÇÿÀü€u„8€Cı\é¿ù‡Oÿ\ïÿş\ëwü·¿ş§O\ßú\Ö{\æ6\0l„8€\Ã,x\ì\ßÿ\ÛD˜N„8€Cx<ø\ó\Ï	rÀ\Ğ\\I€\ÇXb\Ö\â\0šR[]‚%vÀ\Ö$\Ä\Ç\Óı~7?«…2ü(Ã2ü¼ehi\Ü\nf¯^~\ò\ô\òË^ı¹\Õ;}\îG~G•\Ñ$\ÄU\ñ\Û\íf~VeøQ†eøy\Ê\Ø\à\ò:À_¼\õoµ—\Ø\és?\Ê\ğ;ª–\Ó4\ñWÿéŸ¼¾Kş\Ïÿş¶ù\ï9,±<Ğ€\÷9¸‚^\ß\Õ\ì\Úú<G3}½4g\Õ¸B@uetw¼\Âxë¬œ·\ØqU„8€ª<\Ë\è\nyk[\Ñ\ö,±>„8€j<\Ë\è\nhk\ÛK\ì€! \Z\Ï,¼$`Yb\Ö\â\0ª±\Â4¦·¶\Ëa‰°\â\0ª\È\Í\Â=\Ë\èkXb\ŞEˆ¨\"\÷Fú\ÖYxj\Ï»\êÈ¬3!\Ä\ì¦`´B3\Ø;·h™œ%v\\!`7…¢–A­Y¸EK\ì[Âœ%vÌ€°[\îyx\ë°\Ôşs\ËùKTwf\å!`7+ƒK\éK¶.±kf\å!`—\Ü\óp-w[Ûµ´u‰Y9FCˆ\ØE3X+ƒ–\Ï\Ã\×l]b\ç\rvŒ„°\Ë\Ù\Ï\Ãs¶.±k;k@Oq`\'\r\öaù6¥Y(\èf3\Î\ğr¿€\Å\Ú\æ[–\Ø\ÏZE\0¼q`ƒ­Kµ¢\íf\nt\ë…¦µ\ÍY\Ô\î[‚œ\åu\ôŠ\n\ì	\ï”\ö£Yü\È¡º[\Çœ\ñR›‡‚¹$\Ì\ÕW9zDˆN\n\\k€\ß+„¹Uf\ïr!\Ş\órt\é¬\\\ß%\È\ÑBph\à±g{\ni\ëX¥µ]Or\Ï\ôc9zCˆ¹ ªI!1Ò¬<\×6\Ö6=*Y^\'\È\ÑBX‘[.n¥\çe\è\Ø\Úû\n;k›^•,¯\ä\èE“<O\÷û\İü¬\Ê\ğ£¿´Œ’Y¸v…š–gEÖ¿¥Á\ğ\Õ\ËO^~ù\Ñ[ÿfQ\Ù[ƒâ¨¶Z;¿µ]‰£û\\\í\İ\"È>V(\Ã\ï¨2š„¸*~»\İ\Ì\Ïj¡?\Ê\ğK\Ë\ğ</\Õwr\Ï~\Ã[\í\Zø_ß‹w\öc\Ñ6[‚üˆ¶ú\Îwtƒ³|5V\Î:¯¼\ÏÉ½\Çx\Öq\ÔF~G•Ár:°\"\÷B›{k»%\nsm\ã\íIÉŒ\ïH¹UŠ^j[S;Èq`…‚\È\Z¸c[6\ÌÌ­ıY\ö,­·’qk›\Ñxƒ|\ôŒ‹2ra»\çmr¡wV\ŞÛŒo­\Şú\Ì\ÚfD \ïuµ\ó#ÄŒÜ’ú\Ş¸4‹-\ÈXVı‚½m\ÒOÿ\ôv“…k \Ä‡\Ü ¾w¦\í½A\ŞÃŒ/·”>[ yû§‡¾Áµ\â€C.´J_p³xƒB\ß93,T¶U¯˜µ\İ\è<ısv\ß\àzqÀÁ3€\×¼=\åH›†­r\ï¨ş\Öv3\È\İ\Ì\ÉH¿q\ã#\Ä§\ÜNµ–½A~Æ’µ\çúÙ–\ÒS¹¾\Ñ\ç\Ì\ÆqBp\Êı¸Y\Í¨7È\n‹\Ü\Ë}A\Í6\è•\çEDf\ã8\n!8r\ğ\ö,\İzf½\nQ\İr´?Ñªƒxn$b*Çª\Ãlr}3\Û\Ûù\è!\È\rŞµŸU\ç–\ğ%+ˆ·„o\rW\n.\ÏJ‰\ÚCıÁ\Ò:Z\"ÄÁ»\æ \í)OŸŸ\Ú1•µ°\ò\Ü`ú\îUV)p,B(”¼\ã%\îx;,k+\ìJ/7û?›üŠ¥>´\Úcf\ç\êÏ«\İ\ğ B(¤À²\èÀ;3\Öw4¨‹n4¸‡À×Ÿc\Ö\ö=\Ğ1Xmt\nbO?/a¹5\âÀ{\ïY(€¬¶¹‚\Ú7V\n\ô°Jc•,!Ä\rz·–ƒ­6¹­\Ú n“š/j?\Ì\ÎQ‚6º\Âl\\%Ë»\ïB\è\ï\á³\î5\Ï	\Ú„8°Q:¨\÷F\õÓ¬Ya \nš˜b‰u¼W¥¶Š\Ã9,}[\ßUÛ©\İk†¹ú>ÁBØ¨·%u…³·ºÒ¥\ó’G	\núZ³s\í‡~……6\êa9\àn£d\ö\í¡\ğ¯q¾\Ğ\ÏH\âÀ\ZĞ­A6¦?¬¾/ú»t…o˜¥•\î\ñ9zê—¸\Í\Õ\Ö\Ö\÷¶\Ğ9°7\Ğ\éw\Äq`ƒt Oi¶¶[£Á9¥\ëşP&½1S«¬\ïÖ \ò¶<?\×\÷[\Öc!Ä\r¬Á5Vk\Õ,Pû#\Ä\Ûj9û\öPy%a®›;k?¸&!şx<\î\÷»ùY-”\áG~2\Ò[*7À–\Ç\Ö§\Ï}Ô—ÿ\ëşÇ§—_~\ôª[Í¾½\ÇQ\æi=\és¿™\Êh\âªø\ív3?«…2ü(\Ã\ÏSFX\â^¢`°¶Jckˆ\Ó\çy¡_ø‹¦³\ï\Ò\ã\Ğ2{|NY\Òú\Ò\ç~3•Ár:P(\÷<\Ü\Úf«­!uqªms7^g\È\İ,*\è­\íp-„8P\È\ZP…ƒµ\ÍV„x]\n\ëx¹ºv\Õ\×5\Õ{\İqB( \çÖ€\Z\Ô~\áˆ¯\'\Ù\ö8ûN\å–Õ­mp-„8P „\ê’\ÚÁ@ˆ\×1\Â\ò¹%®wŠsBˆr\Ï)k¿\ÙLˆ\ï3\Ú\òy*®{ŠsBˆ^\Ş$Ä·S€\Ç}3\Ê\ì;\È=º\á™8„\n½¼Iˆo¯˜¨\íFpQ½\Ã1Xj¿1\â@µµ\ÅÌˆ/\ßh:[\Í=¶‘¿”\ã!Ä\Ö`\Z´ø¹]B\ÜO¡6C€\ç–Ñ…Y8Bp\Ê\r®-VB\Ü\'}ş­v³¾7‚øFd	³p„8°Bƒ¥f\Ør\Æ3JB<o\ô\Øb\é±X˜…#FˆB€zip­=C\"\Ä×©\ÍCû«Fp\É\İ(r Eˆ\ÏsI‹Yo­0\'Ä—\Í\ğü;ß,a!<\êšZaNˆ\Ûfp\Ï2úÇ‰úqÀ\Âs/\r¼{–x	\ñw\Å>\Ã\ÌÔ»\êSûQ\r\æ@ˆ\ÏÌ¨„\Âf\Ë Lˆÿ\Ú/pµ\õ½\Ñ\ÄÇ´„et,!Ä{—\ÔS[bBüµ4ÀG-\ğ¬øp‡5„8°Bƒ¬\ÂC©Xƒl‰\Ò\Ùx<\È[Ÿ_\Ú,n\ÃY<=®%³/\Ú \Ä§\Z3\ó­!~\Õ\ÙXúXc¦@c5\â€S\îÿ`æ™©[û]s\å\\\Ç?S€\ç\Î%Q\È[\Û1BpZxCÈ®ıf·-³ª0û¿Zˆ\Ï\à\Ş\çà¥«6¸&Bp\ò„¸(p\Âs\ôğ¹¶\÷\åBüJ³²4À­\ïŒ*>¶53İ´ -Bp\ò†xL³©=3ª«…ø\Ì\î}‘m\ë\r®©Iˆ?§ûın~VeøQ†\ßZ[B\ÜRr¡\ÌÒ}\Äş°|\Äã°¨Œ\ßüú»ooÉ—™ÚŠ2|TF“W\Åo·›ùY-”\áG~ke\Ô\n\ñ’\ão0—>O­?–f\à£Ç’\×ş\â\Í1Zt\Ü{Vmfi+\Ê\ğS,§N!P-{fPK\â\å×™Ÿ‘¦>Û±®\İü\Åf\îc´CˆNg†¸\õù\âcœ1À\Ã;\r9¥+-@@ˆNk!\Ş\âÅ³\0-nz0{€{~”LZœ;¸BX¡XË¡¹%\Ñq¸i˜q–6{€\ëx\Â\ñ­™\õ\r\Ç!Äk3\ïT\é\Û\ã9q\È\éF\ÂúÎ¨tl\n/n\ï\ğ\"\Äƒ\÷e¤˜B_e\í¯\Ô\ÌK\é\ñ\Í\Ñl\ß|­™\ñ\æ\ç \Äƒ5\ğz\í\r\ó8f[J\'À_#ÀQ!¬·”–Á·„y˜…‹\õù¨\âÕ„c\Ë!ÀQ!\Â3Û½Jg\å³\Î\Â\ã“\ÙVJ|¶›œ\nšZA.\Ş \Ë\Í3=Wp…v\Ğ\ñY\ßUI€\Ïv\ó‚>\âÀ-{*tj„¹\'¼T^øş,~|LW\ğ\Ú?½\0„8Q2X¯±\ö7³„]\Ün3­,^\â@Fü<\×â™©\çBLÁ¾«€°¾3ü5­\â@F°}G\Ï}\×\Â|my|Æ·¶\ã6›\ém\ìø\ñ@\Îl\Ğ\'BX‘›u¥³Lr\Z\ækƒyü\Ò\×,\ÏÁ\ã›h‹V\än+xµş]r!–AÆ›!À\Ñ+BX¡ ²\ê \Òk\â}\Ï\ö|¦ #À\Ñ3BX±\öœ;]J/\ö3ÃŒu\Ö\Ùâ•…^b\Ãq`A\îyøYW<·>\Ú\"ÏÕ‰\äVab8\ÎBˆrƒøt½f\áq;\Í\à\ñ\Ëy98\ÎDˆ-£Æ³KË\ç\Øa£‡^ü¼x†\É\õ{l–cÆ¸q \Ï*\×\ìy\î/\Ó[Ÿb\Æ\ÙJ|–Ÿ\é\Ç\Øq\à™7À\r\â[fã¡œ\Ñ_\07Ã‹l\êÇ’\0Ÿ\å±\Æ\×$\Ä\Ç\Óı~7?«…2ü(\ÃGƒ\óW/?yzù\åG\ï\ÚK4\ğ—\è\÷·ùªŒ–\ÏR[·•nDB[µ´#Î«?ş‹§\ßüú»fÿZ¶/× eø©Œ&!®Š\ßn7\ó³Z(Ã2\ò\Â\Ò\ğ\ë\0\ñÖ \í¡@\ö\Î\Ê_Æ‹¦!Ş²­\ÂspµÕ§\õ\'\æwji}^©\ÏJú|\ë\r× eø©–ÓgZ¶n/m\ï\äÃ²\íˆ/E…›p¼\ÖwFnF<¼}•>_’\ç‘C<~n\ì]y\èY\â@¤V¯½¹<jˆÇ¿½l\Ä >\õ•µ „8©\âkƒÿˆ!/£l%¿Ä…\0\Çq b\r\æ1…€\ç\ÙùZ\0„ iùb[m\á\Æc\ä\ç\à\á<pŒ‚\å–YC€\éùh.\È\×fÙ£…x¼:1\â³a­\"”øH7W\0!<\áº$\rfı})\Ì\×^ú\n¡8\Âl/^F_»1\é•\ê\ïY9	\Ö\Şe\0zDˆ¿‡•eiY3\Óx–§?\çf«aÆ¿´Ï„c¡®)\õC\èW\0Bø½x\É\ØRs:Jˆ\Çm2ZÀ\à¸\nBø=k`­-—Š\Æú¼#/£\çn\Èbº‘\"À12B—¥±\ä^zª=c!\ÄG]F\Ï\õeLßµ\öŒ„\Ç\å(DN\ÖÀn©=C¼\æ¿–Q—\Ñ	p\\!K)}[Yjm¼T\İ[ˆ\Çue]u.	p~„3!\Äq)á¥²\nıša\Ûsˆ‡0e=^\Õ\ğPÿ[ûFEˆ\ãR¶„x ™i\Ğ\í\õ™øh\Ë\è¥>Ò£À‹Ç¥”ü)\ÍT\÷y¸‘\èi¶¯Œ°Œ\ßpä¨	pÌŠ\Ç\å”>O\í]^\ÔSˆ´Œ^\òü›\0\Ç\ìq\\RIX\öy\ñ^^°\Zi½¤\ß\ô]kÀLq\\’B\Ø\ZøKl]vA´uûš\âe\ô\ß\ÚV=	p\à]„8.\Ç\ó\\\Ü\ò[‚¢·g\Ï!{^F/}¡‡vBˆ\ãrr­Ppä¾·%Äµï°½\õù‘\âp\ì\õG¯J\\ß·\öÌŠÇ¥\Ä3\á%\ñw×–p·_øß½\Ü·\Ã\ÙuYRú\ã€8®ˆÇ¥¬…²XK±ú·tV¾eÉ¶§¥\ôV,qır\Ô78®ªIˆ?§ûın~VeøQ\ÆkYø\Çÿ…Y†BB3C…‹\ö“~\î‚é«—Ÿœ\ÚV\ñ\õ›‰V}\ßh©­^~ùÑ›¿§j¬\"p}øQ†\ßQe4	qUüv»™Ÿ\ÕB~”\ñZX\Ê^¢@ku\ñ\r\Äş\é¿8µ­Âª‚şk}\îÕ¢­Ò•’\×ş\â­j=\á\Ü\õ ¿™\Ê`9—\à™…oa{\Ä\Ë\Ã\Ö\çG‰\ë\Ñ\Ût\îQGl\Ï\n0B—‡—¥Ö¬\Î\ß@œ>½\Ô#¥z•8Ï¿? \Ä1½³g\á! \ö._\ï\ÕK=b8°!\é\åf\á-C-.û\Ì\0Š_f\ë%\à\áù|¾G€\ï\"\Ä15\Ï,¼U8\ÄÁy\ö¯4\ra\Ù\ò±A	O¿8°Œ\Ç\ÔÎš…\Ç~vp\Æm\Ğ\ò±Wi€[û\0\ğ\Z!iyÂ¢Å¯ü\ìŠÛ ‡—\ÙJ¼—U g„8¦u\Æ,<©f‘\ág\ã{¨\ÔGˆcJÀ¨=3Mü\ì\ç¸q}Î…\à@„8¦”û\ílR;\Ø>\Úo.q}¬ÏB€\í\â˜NIh\Ô\n\Û˜5\÷¹Gü\0;³>%}q\öüÀˆqL\'T‹f¦ş® ±\ö\ã?{o\ñ¢\Ü¡>g\ÎlÕ®¹¾p`BS\ñ\Ìü´ú^\ò=\Ë\êqy½Q|S±\÷eh\ÇT<³\ğ\ğ\İvú·­a\ï\Ãúüh\ñMÅ›“½¼~\æJ0BÓˆlIü|8şş–e\ğ^3\Â\óÌ›\n\ÏK…B€û\â˜FX_b[œ-\Ò\Û,\\7(\áXÏº©m’C€u\â˜B`K¬·´ã·¸K–\Ô{œ…‡›˜³n*\â¶\\C€\õ\â˜Bn¾aÛ’%\õ\Şf\á\ñøŒ)\ó<Ê^\Ú˜!\áy–p\×f\Ù[–\Ô\Ã~{˜…Ÿ½*@€\ç!\Ä14O€\äÂ¹tI=¾i°>?Z¸	9+$Õ¾¡=–¨ng¬\0³#\Ä1´½³\ğ@!£\ïz–\Ô\Ãw{˜…Ÿı2›\÷MthƒÇ°<³po°…Ù¤B\Éú<ˆC\Óss\ĞZ¸¡8c\î}‘\0\Ú!\Ä1,\Ï,\Ü\Ú\Î\â]R?34S\ñ\ñ”(\éaµ˜Y“<O\÷û\İü¬\Êğ›±Œš³p	ûû\ê\å\'Oşg\ß2¿\Ï\Â\÷„f¶Š\ß:Î–ı¡²u£¶zù\åGo\ê‘*yQpÉŒ\çn+”\á7SMB\\¿\İn\ægµP†ßŒe\ä^¦\Ú2S\Ö6\n¥ÿş‹¶ø¹\ö½7œj´U8ş¥\ãl\Ù¡\ì\×ş\âÕŸS[\Ú\ß2\ã¹\Û\neø\ÍT\Ë\éN<#^²e7^\Öl\Óû\Ù\Ñ\â¥ÿ£—\Ñ=\ÏÁ\àg·p„8†f\ÄK\ö\ÌÃ¾5\ÛA×–›ƒšT§P—½+¥\â²\×}c\\!¡\Ä3\â%{B$Ş¿B2şª£C\Ó\×\Ïú¼¥°Œ¾\æ\ì›\àjq\Ã3¬´ÖB?F8:,­6I\õ\ĞFÀ\Õ\â†\'Hj=‹U`*”4\ïey8,\õ\ïy\\°E|\ó°Duª\Õ\ö\0üqÁ3Ÿy)7¾92,=\í.½\Ü\è\0WCˆc\ç±\Öv38s\İ\Ó\î¹\ßr B\İ\ó,\ç\Î<?k\İû\ãdÖ¶\0Aˆ£{!Ä–\Ì$,£XCˆ£kqˆ-ÑŒ\Ñ\Úvt½/£Ï¼úŒ‚G·<³ÁYg\á\ñ±}Œ\'~œ\è!ny\Â\ä\È%\æ#\Å3\á#\Ñ\óş\ÏÁ~\â\è’\'Àg]\Î=\ë×¼\ò!®(H<\Ïc¯°Œ~\ô’µ§\İùq2 /„8º\á™}³\Î\ÂC\öøœet ?„8N§\åY\Ï,0˜5L\â =rÉšet`\\„8Nÿ_Â¼fS8¾£WtS·¯eÖ•`t„8N¡\Ğ\ò„GjÆŸ	g\ÂG¯2xV@~6ÀÇ¡¼/®¥n³.\ç\Æ\ÏÁ\Õ>\ÖwZ\à×ª\ã#\Äq\Ï\ËS–™ßˆ\'y“\Âsp`„8šÓŒo\Ë\ÒùÌ³o\éı\çÁy\ôG3\n\à-K\ç2û\Ï#«mÂ±ı\Ì\Ù\Ó\'G\×	À6„8ª\ÛŞ³Ï¾\å\Ì\Ù<4T§#Ÿ\ÍØ®Iˆ?§ûın~VeøUÆŸÿÙ·6‡·\ä–ogh+…\ãW/?yzù\åGM\Ü:x\ö¿\Æ{5CeøQ†\ßQe4	qUüv»™Ÿ\ÕB~­\ËĞ³\İ\ßüú»¿€\ï‚‡‚\ß3\ó½­\Â\\®¶j¹\âG<û_S\ò|†sW(Ã2ü*ƒ\åtl¶\õ…µ\à\nK\çA\Z¢G7\ÏÁ9\â(¢\àŞ³dh?\Öşg4B€ıl@„8²B[~=ªe\ö·\ÎSg¸·ß®²\"Ì†\Ç*\r\îÖ _Ja¢@³Ê˜\Õ\Ùÿú\Z!E\ŞX£¥\Ü+†\Ä\Ù\î½ùº\Ú\Ê0B&o,Q8\\u†7J€\ó\"0>B\ïHC¨\Ä—\Íci€\àŞ¾\ãE6`„8\Ş\áù­^)ms\å\ğ–ø-\ğ3~|N\í\ïıÉ£\ë \rBo)™…_y\É<–†§ş|\Æ\r\r\\!·xf\áWú\ïb\Ü6\nR\ë{­yœ¾\æBˆ\ã-\ÖÀ#ş \rÎ³\Ú\Æ\à%¿RÀq¼‘\Î*S¼\õZº|~æ¯\õ8?JÌ‰\Ç¹¥tfr\ï¶Ñ™\á\è\rp}\Ï\ÚÀøq¼a@\Ì\Ú\æ*4\ÓÖŒ;´Å™³o\ñ8«\'À\Üq¼\òÁ\ßàª³9\ëÇ¶\Î^š&À„8^É…ø—\ÒÓ¥s…ç™³o!À\Äq¼’{©íŒŸ{>‹\õ;\ã\Ïo!À¤q¼\ò\á¿ü#3‚+„¸\Â[w+Ö’ş¸B¯\\5\Äu\\zÆ¯ş­‡cÎ­\Äp\àzq¼¢À²‚!\ĞLP3\ÕY\Â\\\Çb\Ín{	o)\r\ğ–ü‹\Ç+¹\ÛŸ–˜#ºB[.—½İ ¨>V=-8p]„8\ŞX\n¸{w…Ï™¯rU\Õe-´EŸ\÷~\Ö\nÁ¸6Bo(Ô¬ B8*d¼^ûÖ¶qĞ‡°\âº\Äÿ\Ó6\Ú>\ê\\X\Çz\rnQ½J\\ßµ\ö\à:š„ø\ã\ñxº\ß\ï\ægµP†Ÿ·£‚RA\Z¾‚Xaúwû—O¿ù\õw\İaº\ÅW/?yzù\åG\æg©p\ã?®\÷š³úCmhÇ’\\€_\í\Üİƒ2ü(\Ã\ï¨2š„¸*~»\İ\Ì\Ïj¡¿’2r!¬°±¶KËˆ^aª\Ğ\íkĞ¿\ğo\ö‚:„µ\Ê\ó†\õ’£ûC\õ\ÕqXÇ»d©b½W[Q†eø\ÍT\Ë\éx‹\Ñ\n˜\ÓÚ¶”,‚?ˆ?³¶\Ñj\ß5\Ú\Æ\Ú€k\"\Ä\ñ¦g¦\ì™\rb™\çf)E€H\âx‡\÷ù,A^.\÷ŞE7U8\0!“\÷¹µ‚|\Ö\å\îš\Ş\Ş6i\Æn\í\0„‡I\á\ì\r½˜\ÅLÑ¦v)}q- M\ä\âXT\ä¢Y#³\ò\×\Ô[\Ã[\ÛYû€!U¥A.W\ó­\Ë\æA­7ÿ\\!¬-A.šQ*”ft\ã\ÖYw \íY>PŠ‡\Ë\Ö RÚ‡‚j\äPW\İ\Ú:–-?&fa\ö\r`+Bn\n\à=AS¨+C°\÷\îªC¨\ÂUT\ÏZ\ÇÓ±[u\0\0/B\Å\ö\Î\Ês´o…| ©üTúT¼¿@\åV=ZQ}f\Ä\0\à„86©9+¿\n\İ8¨İ¬\ö€-q\ìB˜\çi\æMxhG„ù»\ô<es\0-\â¨Ja®g\ÔW\rtf\İ\0Dˆ£™+ºs\Ü\0\ÎBˆ\ã0!\ÔÃ›\áV(\öLa-,“\è!S)\ØEÁ~T¬Ö€\Å\Û\Ç\Âşƒ\Î*_\ÂÏ‡«^\nk@¯q\0\0Eˆ\00(B\0€A\â\0\0Š\0`PMBü\ñx<\İ\ïw\ó³Z(Ã2ü(Ã2ü(Ã2üTF“W\Åo·›ùY-”\áG~”\áG~”\áG~*ƒ\åt\0\0Eˆ\00(B\0€A\â\0\0Š\0`P„8\0\0ƒ\"\Ä\0!\0À q\0\0Eˆ\00(B\0€A\â\0\0Š\0`P„8\0\0ƒ\"\Ä\0!\0À q\0\0Eˆ\00(B\0€A\â\0\0Š\0`P„8\0\0ƒ\"\Ä\0T“<O\÷û\İü¬\Ê\ğ£?\Ê\ğ£?\Ê\ğ£?•\Ñ$\ÄU\ñ\Û\íf~VeøQ†eøQ†eøQ†Ÿ\Ê`9\0€A\â\0\0Š\0`P„8\0\0ƒ\"\Ä\é½\÷\Ş{\åı\÷\ß/¢m¬ı#:%Ä¿ù\Ío>}\ï{\ß{úÁ~\ğ\ô\ãÿø•Ÿı\ìg\ÕhÚ¿Uv\êÖ¢N5¨½\Òú\æê¹µ\ö\è±Nk\ÂùxF¿[}º•£\Õù«z\ÊY}Kuù\İ\ï~W\Åoû\ÛW´ß–\Ç\ÕË˜¢\ò·\ô¡µ¯m\í\ËQÇ\ÃB<œÈºh¬ª•g\Õe‰:\Ğ\ÚO/\Ô\Ùis\í\ÙrpZ’«S\Í\à\ÚC\ç‡U¿#Y}ZJ×–\öc\í¿•~V}j:\ò\ØZ“\Îu«¬³yU\íomß³\Ò1o\ôq iˆ‡\à¶*}”’Àø\å/i\î£„x:\'su<Ê‹·‡\ë«E\ğ‰\í¬\ë±\Ö1\õ>)\Üq\Î\âú\Ş\ã@³?{p	4X\õK\õz\Ç#\Ä\÷Ñ€\Ô\ËEl½x{\\Õ®ª“U\×R½\\‹Ş±c‰ú\Ö\ÚooÖs\Æ\×1\õ6a\ë*\Ä{(U«)B¼\\\Î\ñ^£-o¯\ÇR#\È{¾=\Ç\Ô[P¬Y:{=\×Ö¬y:û¥›W\ãY<›U\×T/+k\ñ\íru:Ë–‹·\çp˜1\ô¶\ÓH!¾tŒ³…x¯}\ÒEˆ\÷‚V}S„x=¹:\â=\÷m\é\Å;\êŠQN\ï×Ÿ\Îi«\ŞkF\nq±úm¦ŸiˆU	\ñ\Ş/@«\Î)B¼B\\\ÇoÕ¡¥\ï(ÁPr\Ş\õ\ŞGÁ¬}X7*3…¸\õ\İ^œ\Z\â{.@4¢\Ø\Ã\ÚwÌªw\Ê\âV\ÙG²Â_§v³êªu.–*m«\î©\ÇQ\ZHªƒU‹µı\íW×ªl9·J¢v\ßr\\%ı•Û·>OÛ¹%Ï±¦mª¶²\öµ…U^\Ì\Úf\Õ9>Q¿Ye¦Fb»B|\Ë]Z¸­ımá¹‰°¶K\åB\\€µ\İ\ÙÔV}ƒ«‡x®.\Òkß¦<‘k\ÛZt\Í{\ÚT<\ç\ç\æ9¨9n\ÄÔ®\Şc\Ò\÷¬}Xr¡y\äu ¾k9^X\åÅ¬\ğ­e¦q µ+\Ä=wv¾\Û\â!\ÄÏ»(—\ä\êt\Ô\à\å97Fºps\çhIÀ\ì¡ÁV7Vb¶µ¶K\é¸ZŸ\Ç:&\ï\r…\÷üÍG‡¸\ä\ê\Ô\êFI¬\òb-C\Ü*/6\Ò8\Ú\â2hyb\â„ø•c•k9pÔ–\ÎÖ³\ğ˜\ÚÍªC,wS\á\é±¶m\Åss\â½Y\"\Ä\ßf•ku-z2\âŒq²–\Í!;\äˆ;hBœ_\â		k»^\õ\â\âißµ\ó\Ï3†}şznN\ÄS/BümVy±V!>\Û8\Ú\âF‘#.@•a•³¶K\â\õ\ô\â£\ö\é’\ŞB\Üxk}m}?vVÿx\Æ7\Ï9Lˆ¿\Í*/vVˆ6¤6…¸gÉ©\å\É#\Ä	\ñ%¹>U=­\íz\Õ[ˆ\Ë\ÖP\ğe«A\İ#w\\\ñ ·Bümg…øh\ã@jSˆ[\r;²QqB|I\î\Ü \Ä\÷\ÛZ§\Ü\õ&\ÖvGÉ…\ç\Ü!\Ä\ßf•k\âµ2¢W\Å!î¹ƒ>28®\âg^”Kr!~\Ô\Ësnœ1n5Sˆ\ç¶;ûzË£†ø™7\ØVy±3CüŒq²–\â\Ï]|bm\×\Ê\ÕC¼\ÇÁĞªG\ì¨W9Vù1\rjG\Õg¯­\Ù\Ò\Ö:\õx,±\Z\ãJ!n\Õ#\Ö\òZ°Ê‹µ*\Û;¨Ï­\í{W\â¹;9]|\Ç\ã\é~¿›\Û\×\Êh\â_|\ñ\Å\Ó\çŸş\ê\Ïi\êÄ¨\á‡?ü\áÓ‡~h~&q™ÏŒ\á\Èş\ğ¬\ÔX\Û{l9\Ü@*j#µ£\êş“Ÿüdµ?JYu\Ú\Ú%ÁwTŸÿ\â¿0\ë,…±7\à:´\õU¯\ØRÿ\ñ1\ÆcIP;\ÄsmU\ã\Ú\Ü\ÓVy±Ğ-ú<=ß¬şˆ\Ç\åJ¸†·Š\Çv«N5¨­ª‡¸\Z@p»\İ\Ì\ík	e´qu\ògŸ}\ö\ê\Ïiˆ§\ß\İ*.\Ã—i\ñÿ§Ÿ~zX\ä\ç´Kl9¯<W,\×[\èš\Ñq‡A{\ë\õQ\âG]ƒ?ÿù\ÏÍº{Cü¨\ãH\Ë\ĞÀk\Õ+–œ\ãc´Î«pŒµ\ä\Ú*7v‹µ]lOX\å\ÅB{¶\è\ótœlq§\Ò2\Òq µUqˆÇ•´´¼ë°´\ñX\Z>\ÖwZˆË´x<µKn`–¥A½µ§^GQ_\è\\\Ûr”„øQrÁ°t\Ş\åú\äˆ\óu\çº\Ê\õaO\Ç\ØÃµi•\ÛrMx\õ8¨½ksQˆ¿\÷\Ş{f…b-;\Âr\õ\ïÉ©c´¶\ßKû\Í\r\æú\Ë\ÚGKs\äh!Ì­ú.\é1Ä­z\Äq{[9\âu\î\÷rmZe\ÆZg‡§O¶eH…øû\ï¿oV$fm\×!^R:iD¾y\ï\ÍCpF\Èª¯U§³©^V}-½…¸BÈªGli`&\Ä\ß=Fı½†p}Ze.Ñ˜×¥«\ÜX\ë—^Ç=\×.!ş,×¹=‡¸”\êZ\ß\é\ç\ôz«^V}S½…¸U‡”µ\âocÉxG´·Un\ìˆ—\ÑÇ!şl\ô\÷:gJ\Û\ï,\Z¬¼Ë‹G\ò¢½„¸\Î5\ÏM\ã\Ú\ì\ï\'Ä˜…‹Uv\ì¨—^Ç-ANˆ?=\ÄE\'¦µ³\õ\à‹\Ş\î\Æ=\é\Ù!^\ÚnkALˆ\÷\âG¸X\åÇq	\çsOa¾¥?ª‡¸’#\å.±%5CˆKoA\Ş[€\Çt«½¼\çQk¹\àR=­\í}~¿†-m“Œrû$\Ä\Û;2ÀÅªC\ì\èFR\ÕC¼GÖ±¤JC\\„¸L¯^\î.\Ó6\Õ{\è‚\ô\Î^sƒªk»@Ÿ‡\ïªl\ë;G\É\rD¹ÁRmfmwOû\é;Ö¶A\Ï!®sMe\Æ\õmÍªG,×GR]jª9¤\ñg¥!\Ş;8Ş“¦¶3ˆŞ©?<7Vk\í6Jˆ{®•\\À\Å\Çr\rºV½b\Öv±C\\\ç\àY7HV}b:g­\íf\â¾ı\ío›\Û[\ñg³…x\Â\Üs\â\ìu\æ\01\Ï@=zˆ{¯“Ü±œ}½\Í\â=\\›V½bWq\ñ\ô\õ\÷¿ÿ}s[!şl\Ö\é\"\ÑÀ¡TtL\'\ä\ã\ï‹\ö¡v#¸ı\ÔnV\Ûkm™>}¾{Fˆ\ëŠ\ë»&w½•ì«…\\[{\ê—\ë\ë4ÄµO‹µ\í\Zm£²Ãµ\ÙK8Zu]%Ä¥\ä\Ü\È!ÄŸ\å5ºµ\İ,r3\r\Öv(SÄ©C|\í\æÃ²wU¢µ\\x®\õSPc V?\æÆ¦”\ê\Şc Zu])\Äs}úÓŸş\Ô\Ü\ÎBˆ?#\Ä	\ñ#\äÎ³\ÑB\\\çÅ–°\õ\Ô\Ï”-\ä®\ñp\Í\ÙÖ– /\Ùÿ¬z\Æ\ñ?øÑ~dng!ÄŸ\â„øJ‚8\ÕKˆ\ë\\\Ğ\õ²w¦œ99#ˆ¬z¤<S3\Ä%w¦B?Yû:ƒU\ÇØ•B<w-Ÿ\Z\â:i”k±%¥}Y\Û„8!^ƒ\Ú\Ñj\ß`m`/\r\ñ\ôZ\ÙK¡]s‰[û´#v\ôyç¹±\ğÖ©vˆ‹ú5w¥\Ô\ÎÖ¾f\Õ-v¥\Ï\õ\á©/¶YÛµ¤AÅªG\Ì\Ú.•PqB|/Oh­…dIˆ@ƒ¶u){­øp\Óc•Ÿ\ò†o‹—QƒÜªW\ì*!k…OXÛ¥qB¼%o@¬\rd³…¸x\ÛE\ç_« \òŒ!A\Éu\Ğ*\ÄE\çInÿ©³¯a«N±+„¸\÷|ÿ\Æ7¾ano!ÄŸ\âs†¸‚\íL%­¾oC Ï­\í‚\Ü\ö=\ÒÀm\Ë‡:N¯k«kT¦¶\×5¯ıY\å,)	Ş–!.:o(:Ş³\ÂÒªO¬e½tÎœ©d(\Í\ZBü!>_ˆ—\Ä\Ùr¡¤ÁÀ\Ú.\Ğ\ç\Öv½Ë{½(Z‡x°%È·\Ş\0\ía\Õ%\Ö*\ÄgR„ø3Bœ?“\çüš5Ä¥4ˆ¶\åü?*\ÄeKkk_­X\õˆ\â\Ûr†Fˆ\âg\ò\Ü}\Ï\â\ê«\\\èi\Ë\Ì\õ\È—-\çû‘An•#Ä·g„ø3Bœ?‹\÷Â9\ÄEıU:£lM\çı–UqQª\ÎVyK\nr«\ì\Ø\ÕC|\ëyFˆ?#\Ä	\ñ£•\Ä\ì!\ô\ä{¯ù3B\\¶ù\ã›Un\ìª!¾\çFQš„ø\ã\ñxº\ß\ï\ïl_S(£eˆ\ñ\ÅOŸşù«?·:Él+\ë³`oˆ\÷r±-o\Üç­¨ŒO?ıÔ¬\óš’\ï±?J¨\ït\Í\Õq:\×k\ÌN\ã·£vˆ\Çı¡\ö+½\Òq\ç‚tOŸ[e\ÆBÙµ\Ï+k8ã¼²\ì½\ñV[5	quÀ\ív{gûšB-C\\\ğ\ÙgŸ½ús«?²­¬Ï‚½!\Ş\ËqÄ¬‹7\'\î\ó\ÚB8|øá‡›Úª$\Ä{\ì->şø\ã§_ı\êW\æ\ñ\Öú¼Vxqˆ[\çU\íOû£E\ï\és«¼X(·\öye-¯\ó`©Œp­µ³—Úª8\Ä5P¬±¶kI!n\Õ#fm—\ÒemÔ¾\àz“kÇšƒ\ÛQt‘X\Çr$µ›\ìY.®|ª/u|q0\Ö\Ô\Zı“\Ò~­~\nZ”i\É\Õ#¥\ï\×˜”UV¬E™2\Û8*\nq\0\èÁ×¿ş\õW>ø\àƒb\Ú\Î\Ú\'0\"B\0€A\â\0\0Š\0`P„8\0\0ƒ\"\Ä\0!\0À q\0\0Eˆ\00(B\0€A\â\0\0Š\0`H_{úÿŠ§\å)O¯‰\0\0\0\0IEND®B`‚');
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
