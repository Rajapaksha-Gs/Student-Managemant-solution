-- phpMyAdmin SQL Dump
-- version 5.2.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Oct 25, 2025 at 01:14 PM
-- Server version: 10.4.32-MariaDB
-- PHP Version: 8.0.30

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `attendens_managment_system`
--

-- --------------------------------------------------------

--
-- Table structure for table `user_table`
--

CREATE TABLE `user_table` (
  `user_ID` int(11) NOT NULL,
  `User_name` varchar(50) NOT NULL,
  `user_Pass` varchar(255) NOT NULL,
  `user_pho` varchar(15) DEFAULT NULL,
  `user_D0B` date DEFAULT NULL,
  `user_CINC` varchar(15) DEFAULT NULL,
  `user_gender` varchar(6) DEFAULT NULL,
  `user_email` varchar(30) DEFAULT NULL,
  `user_add` varchar(150) DEFAULT NULL,
  `User_Role` varchar(20) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4 COLLATE=utf8mb4_general_ci;

--
-- Dumping data for table `user_table`
--

INSERT INTO `user_table` (`user_ID`, `User_name`, `user_Pass`, `user_pho`, `user_D0B`, `user_CINC`, `user_gender`, `user_email`, `user_add`, `User_Role`) VALUES
(1, 'student_user', '12345', '0762568784', '2001-05-31', '200115204635', 'Male', 'user0129@gmail.com', 'Sri Lanka', 'Student'),
(2, 'system_admin', '12345678', '0762568586', '2001-05-31', '2001152558835', 'Male', 'admin0129@gmail.com', 'Canada', 'Admin');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `user_table`
--
ALTER TABLE `user_table`
  ADD PRIMARY KEY (`user_ID`),
  ADD UNIQUE KEY `User_name` (`User_name`),
  ADD UNIQUE KEY `user_CINC` (`user_CINC`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `user_table`
--
ALTER TABLE `user_table`
  MODIFY `user_ID` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
