-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jul 29, 2021 at 04:30 PM
-- Server version: 10.4.19-MariaDB
-- PHP Version: 7.4.20

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `db_penjualan`
--

-- --------------------------------------------------------

--
-- Table structure for table `tbl_admin`
--

CREATE TABLE `tbl_admin` (
  `id` int(11) NOT NULL,
  `username` varchar(255) NOT NULL,
  `level` varchar(10) NOT NULL,
  `password` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_admin`
--

INSERT INTO `tbl_admin` (`id`, `username`, `level`, `password`) VALUES
(1, 'cimen', 'user', '123'),
(2, 'gede', 'admin', '123');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_barang`
--

CREATE TABLE `tbl_barang` (
  `idBarang` varchar(6) NOT NULL,
  `namaBarang` varchar(200) NOT NULL,
  `hargaBarang` int(11) NOT NULL,
  `jumlahBarang` int(11) NOT NULL,
  `satuanBarang` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_barang`
--

INSERT INTO `tbl_barang` (`idBarang`, `namaBarang`, `hargaBarang`, `jumlahBarang`, `satuanBarang`) VALUES
('B001', 'Buku SIDU', 18000, 21, 'lusin      '),
('B002', 'Pulpen', 1500, 11, 'Unit   '),
('B003', 'Spidol', 5000, 58, 'Unit  '),
('B004', 'Kertas Hvs', 5500, 57, 'KODI  '),
('B005', 'Tinta hitam', 12000, 67, 'botol  '),
('B006', 'Pensil 2B', 2000, 37, 'pack '),
('B007', 'Penggaris 30cm', 5000, 25, 'Unit '),
('B009', 'Mouse Laptop', 15000, 12, 'Unit   '),
('B010', 'Senter', 68000, 16, 'Unit    '),
('B011', 'Paku 5CM', 20000, 2, 'Kilo'),
('B012', 'Amplas No 500', 11000, 2, 'meter'),
('B014', 'Gergaji', 220000, 12, 'Unit    ');

-- --------------------------------------------------------

--
-- Table structure for table `tbl_detailjual`
--

CREATE TABLE `tbl_detailjual` (
  `id` int(11) NOT NULL,
  `idPenjualan` varchar(200) NOT NULL,
  `idPelanggan` varchar(100) DEFAULT NULL,
  `kodeBarang` varchar(100) NOT NULL,
  `tglJual` varchar(100) NOT NULL,
  `jumlahJual` int(11) NOT NULL,
  `subTotal` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_detailjual`
--

INSERT INTO `tbl_detailjual` (`id`, `idPenjualan`, `idPelanggan`, `kodeBarang`, `tglJual`, `jumlahJual`, `subTotal`) VALUES
(1, 'P-53-3623', 'U008', 'B004', '18/07/2021 13:36:32', 2, 11000),
(2, 'P-53-3623', 'U008', 'B009', '18/07/2021 13:36:41', 2, 30000),
(3, 'P-53-4544', 'U015', 'B004', '18/07/2021 13:45:53', 4, 22000),
(4, 'P-53-4544', 'U015', 'B009', '18/07/2021 13:46:01', 4, 60000),
(5, 'P-53-4833', 'U009', 'B006', '18/07/2021 13:48:40', 2, 4000),
(6, 'P-53-4833', 'U009', 'B010', '18/07/2021 13:48:54', 1, 68000),
(7, 'P-53-5549', 'U009', 'B006', '18/07/2021 13:55:58', 2, 4000),
(8, 'P-53-5549', 'U009', 'B007', '18/07/2021 13:56:09', 3, 15000),
(9, 'P-53-5744', 'U008', 'B006', '18/07/2021 13:57:53', 3, 6000),
(10, 'P-53-5744', 'U008', 'B010', '18/07/2021 13:58:03', 1, 68000),
(11, 'P-57-0230', 'U004', 'B001', '18/07/2021 14:02:43', 2, 36000),
(12, 'P-57-0230', 'U004', 'B010', '18/07/2021 14:02:52', 1, 68000),
(13, 'P-57-0002', 'U004', 'B012', '23/07/2021 09:00:36', 10, 110000),
(14, 'P-57-0002', 'U004', 'B011', '23/07/2021 09:01:20', 4, 80000),
(15, 'P-70-0830', 'U004', 'B010', '23/07/2021 09:08:40', 2, 136000),
(16, 'P-53-1017', 'U004', 'B010', '23/07/2021 09:10:23', 2, 136000),
(17, 'P-53-1017', 'U004', 'B002', '23/07/2021 09:10:33', 4, 6000),
(18, 'P-53-0705', 'U004', 'B011', '23/07/2021 10:08:15', 4, 80000),
(19, 'P-53-0705', 'U004', 'B011', '23/07/2021 10:08:28', 3, 60000),
(20, 'P-77-0949', 'U007', 'B004', '23/07/2021 10:09:54', 2, 11000),
(21, 'P-77-0949', 'U007', 'B003', '23/07/2021 10:10:00', 3, 15000),
(22, 'P-28-3049', 'U004', 'B003', '29/07/2021 17:30:58', 3, 15000),
(23, 'P-28-3049', 'U004', 'B011', '29/07/2021 17:31:05', 5, 100000),
(24, 'P-53-1509', 'U008', 'B006', '29/07/2021 22:15:14', 4, 8000),
(25, 'P-53-1509', 'U008', 'B011', '29/07/2021 22:15:24', 2, 40000),
(26, 'P-53-1648', 'U0099', 'B006', '29/07/2021 22:16:55', 5, 10000),
(27, 'P-53-1648', 'U0099', 'B010', '29/07/2021 22:17:03', 1, 68000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_jual`
--

CREATE TABLE `tbl_jual` (
  `id` int(11) NOT NULL,
  `idPenjualan` varchar(11) NOT NULL,
  `totalJual` int(11) NOT NULL,
  `dibayar` int(11) NOT NULL,
  `kembali` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_jual`
--

INSERT INTO `tbl_jual` (`id`, `idPenjualan`, `totalJual`, `dibayar`, `kembali`) VALUES
(1, 'P-53-4544', 82000, 100000, 18000),
(2, 'P-53-4833', 72000, 100000, 28000),
(3, 'P-53-5549', 19000, 50000, 31000),
(4, 'P-53-5744', 74000, 100000, 26000),
(5, 'P-57-0230', 104000, 120000, 16000),
(6, 'P-57-0002', 190000, 200000, 10000),
(7, 'P-53-1017', 142000, 150000, 8000),
(8, 'P-53-0705', 140000, 150000, 10000),
(9, 'P-57-0928', 140000, 100000, -40000),
(10, 'P-77-0949', 26000, 30000, 4000),
(11, 'P-28-3049', 115000, 120000, 5000),
(12, 'P-53-1509', 48000, 50000, 2000),
(13, 'P-53-1648', 78000, 80000, 2000);

-- --------------------------------------------------------

--
-- Table structure for table `tbl_pelanggan`
--

CREATE TABLE `tbl_pelanggan` (
  `id_pelanggan` varchar(10) NOT NULL,
  `nama_pelanggan` varchar(255) NOT NULL,
  `alamat_pelanggan` varchar(255) NOT NULL,
  `no_hp` varchar(255) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `tbl_pelanggan`
--

INSERT INTO `tbl_pelanggan` (`id_pelanggan`, `nama_pelanggan`, `alamat_pelanggan`, `no_hp`) VALUES
('U0011', 'Rasa', 'Bima', '12345'),
('U003', 'Cimennn', 'Sapaga', '00987'),
('U004', 'Andrian', 'Jatibaru', '098765'),
('U005', 'Hadi', 'Salewi', '07886'),
('U007', 'Ali', 'Sapaga', '123456'),
('U008', 'Gede', 'Mataram', '08543'),
('U0099', 'wawan', 'mataram', '1234'),
('U013', 'Eri', 'Bima', '09876'),
('U014', 'Adi', 'Bima', '65432'),
('U015', 'Sari', 'Sapaga', '123456');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_barang`
--
ALTER TABLE `tbl_barang`
  ADD PRIMARY KEY (`idBarang`);

--
-- Indexes for table `tbl_detailjual`
--
ALTER TABLE `tbl_detailjual`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_jual`
--
ALTER TABLE `tbl_jual`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `tbl_pelanggan`
--
ALTER TABLE `tbl_pelanggan`
  ADD PRIMARY KEY (`id_pelanggan`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbl_admin`
--
ALTER TABLE `tbl_admin`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbl_detailjual`
--
ALTER TABLE `tbl_detailjual`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=28;

--
-- AUTO_INCREMENT for table `tbl_jual`
--
ALTER TABLE `tbl_jual`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
