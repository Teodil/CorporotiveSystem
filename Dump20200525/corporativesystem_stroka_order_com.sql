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
-- Table structure for table `stroka_order_com`
--

DROP TABLE IF EXISTS `stroka_order_com`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `stroka_order_com` (
  `Coming_Order_id` int NOT NULL,
  `Product_id` int NOT NULL,
  `Amount` int DEFAULT NULL,
  `Price` double DEFAULT NULL,
  `Procurement_Plan_id` int NOT NULL,
  KEY `fk_Stroka_Order_Com_Coming_Order1_idx` (`Coming_Order_id`),
  KEY `fk_Stroka_Order_Com_Product1_idx` (`Product_id`),
  KEY `fk_Stroka_Order_Com_Procurement_Plan1_idx` (`Procurement_Plan_id`),
  CONSTRAINT `fk_Stroka_Order_Com_Coming_Order1` FOREIGN KEY (`Coming_Order_id`) REFERENCES `coming_order` (`id`),
  CONSTRAINT `fk_Stroka_Order_Com_Procurement_Plan1` FOREIGN KEY (`Procurement_Plan_id`) REFERENCES `procurement_plan` (`id`),
  CONSTRAINT `fk_Stroka_Order_Com_Product1` FOREIGN KEY (`Product_id`) REFERENCES `product` (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `stroka_order_com`
--

LOCK TABLES `stroka_order_com` WRITE;
/*!40000 ALTER TABLE `stroka_order_com` DISABLE KEYS */;
INSERT INTO `stroka_order_com` VALUES (1,1,300,5,1),(2,1,500,12,2),(3,1,600,34,3),(4,2,300,6,4),(5,2,500,15,5),(6,2,600,25,6),(7,3,150,34,7),(10,1,228,4,10),(11,1,600,3,13);
/*!40000 ALTER TABLE `stroka_order_com` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-05-25  0:55:19
