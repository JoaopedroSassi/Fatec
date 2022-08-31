-- phpMyAdmin SQL Dump
-- version 5.1.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1:3312
-- Tempo de geração: 25-Set-2021 às 00:47
-- Versão do servidor: 10.4.21-MariaDB
-- versão do PHP: 8.0.10

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Banco de dados: `db_vbs_spell`
--
CREATE DATABASE IF NOT EXISTS `db_vbs_spell` DEFAULT CHARACTER SET utf8mb4 COLLATE utf8mb4_general_ci;
USE `db_vbs_spell`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tb_ranking`
--

CREATE TABLE `tb_ranking` (
  `id_jogador` int(11) NOT NULL,
  `nome` varchar(60) NOT NULL,
  `acertos` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Extraindo dados da tabela `tb_ranking`
--

INSERT INTO `tb_ranking` (`id_jogador`, `nome`, `acertos`) VALUES
(1, 'JOAO', 6),
(2, 'RAYANO', 8),
(3, 'NESS', 6),
(4, 'PEDRAO', 3),
(5, 'BRUNARGAS', 2),
(6, 'BRUNO', 15);

--
-- Índices para tabelas despejadas
--

--
-- Índices para tabela `tb_ranking`
--
ALTER TABLE `tb_ranking`
  ADD PRIMARY KEY (`id_jogador`);

--
-- AUTO_INCREMENT de tabelas despejadas
--

--
-- AUTO_INCREMENT de tabela `tb_ranking`
--
ALTER TABLE `tb_ranking`
  MODIFY `id_jogador` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
