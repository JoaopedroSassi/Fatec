@echo off
title Aula 02 - Programacao em batch
mode 60,30
color 0a

:inicio
cls
echo ============================================
echo      Gerenciamento de Pastas e Arquivos
echo ============================================
echo [G] Gerar Arquivos
echo [O] Organizar Arquivos em Pastas
echo [E] Encerrar o Programa
echo =============================================
echo.
set /p op=Digite sua opcao desejada:

if /i %op% equ G (goto:gerar)
if /i %op% equ O (goto:organizar)
if /i %op% equ E (goto:sair) else (
	echo.
	echo --------------------
	echo Opcao Invalida!
	echo --------------------
	pause > null
	goto:inicio)

:gerar
set /p arquivo=Digite o nome do arquivo a ser gerado:
set /p qtde=Digite a quantidade de arquivos a serem gerados:
set /p ext=Digite a extensao do arquivo a ser gerado:
c:
cd\Users\joaop\Documents\Estudos\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_10
for /L %%n in (1,1,%qtde%) do echo Gerando arquivos... > %arquivo%%%n.%ext%
echo.
echo -----------------------------
echo Arquivos Gerados com Sucesso!
echo -----------------------------
pause > nul
goto inicio

:organizar
c:
cd\Users\joaop\Documents\Estudos\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_10
set /p pasta=Digite a pasta a ser criada:
set /p ext=Digite a extensao do arquivo a ser organizado:
md %pasta%
move *.%ext% c:\Users\joaop\Documents\Estudos\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_10\%pasta%
echo.
echo -------------------------------------------------
echo  Arquivos organizados com sucesso!
echo -------------------------------------------------
pause > nul
goto inicio

:sair
echo.
set /p resp=Deseja realmente encerrar[S/N]:
if /i %resp% equ s (exit) else (goto:inicio)