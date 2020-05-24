-- MySQL dump 10.13  Distrib 8.0.19, for Win64 (x86_64)
--
-- Host: 127.0.0.1    Database: corporativesystem
-- ------------------------------------------------------
-- Server version	8.0.19

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `invoice_сonsumption`
--

DROP TABLE IF EXISTS `invoice_сonsumption`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `invoice_сonsumption` (
  `Сonsumption_id` int NOT NULL,
  `Product_id` int NOT NULL,
  `Amount` double DEFAULT NULL,
  `Price` double DEFAULT NULL,
  KEY `fk_Invoice_Сonsumption_Сonsumption1_idx` (`Сonsumption_id`),
  KEY `fk_Invoice_Сonsumption_Product1_idx` (`Product_id`),
  CONSTRAINT `fk_Invoice_Сonsumption_Product1` FOREIGN KEY (`Product_id`) REFERENCES `product` (`id`),
  CONSTRAINT `fk_Invoice_Сonsumption_Сonsumption1` FOREIGN KEY (`Сonsumption_id`) REFERENCES `сonsumption` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `invoice_сonsumption`
--

LOCK TABLES `invoice_сonsumption` WRITE;
/*!40000 ALTER TABLE `invoice_сonsumption` DISABLE KEYS */;
INSERT INTO `invoice_сonsumption` VALUES (1,1,150,30),(2,2,200,55),(3,3,150,100),(4,1,300,30),(5,2,500,55),(6,3,150,100),(7,1,300,30),(8,2,500,55),(9,3,150,100),(26,3,400,94),(27,1,400,40),(28,2,400,68),(29,1,350,35);
/*!40000 ALTER TABLE `invoice_сonsumption` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25  0:55:20
