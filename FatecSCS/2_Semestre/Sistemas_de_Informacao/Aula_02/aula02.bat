@echo off
title Aula 02 - Programacao em batch
mode 60,30
color 0b

:inicio
cls
echo ============================================
echo      Gerenciamento de Pastas e Arquivos
echo ============================================
echo [1] Gerar Arquivos
echo [2] Organizar Arquivos em Pastas
echo [3] Ocultar Pastas e Arquivos
echo [4] Exibir Pastas e Arquivos
echo [5] Excluir Pastas e Arquivos
echo [6] Encerrar o Programa
echo =============================================
echo.
set /p op=Digite sua opcao desejada:

if %op% equ 1 (goto:gerar)
if %op% equ 2 (goto:organizar)
if %op% equ 3 (goto:ocultar)
if %op% equ 4 (goto:exibir)
if %op% equ 5 (goto:excluir)
if %op% equ 6 (goto:sair) else (
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
cd\Users\joaop\Documents\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_02
for /L %%n in (1,1,%qtde%) do echo Ai meu vuaida > %arquivo%%%n.%ext%
echo.
echo -----------------------------
echo Arquivos Gerados com Sucesso!
echo -----------------------------
pause > nul
goto inicio

:organizar
c:
cd\Users\joaop\Documents\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_02
set /p pasta=Digite a pasta a ser criada:
set /p ext=Digite a extensao do arquivo a ser organizado:
md %pasta%
move *.%ext% c:\Users\joaop\Documents\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_02\%pasta%
echo.
echo -------------------------------------------------
echo  Arquivos organizados com sucesso!
echo -------------------------------------------------
pause > nul
goto inicio

:ocultar
c:
cd\Users\joaop\Documents\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_02
set /p pasta=Digite a pasta a ser ocultada:
attrib %pasta% +h +r
echo.
echo -------------------------------------------------
echo  Pasta ocultada com sucesso!
echo -------------------------------------------------
pause > nul
goto inicio

:exibir
c:
cd\Users\joaop\Documents\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_02
set /p pasta=Digite a pasta a ser exibida:
attrib %pasta% -h -r
echo.
echo -------------------------------------------------
echo  Pasta exibida com sucesso!
echo -------------------------------------------------
pause > nul
goto inicio

:excluir
set /p deleta=Deseja realmente excluir?[S/N]:
if /i %deleta% == s (
	c:
	cd\Users\joaop\Documents\Fatec\2_Semestre\Sistemas_de_Informacao\Aula_02
	set /p pasta=Digite a pasta a ser excluida:
	del /f /s /q %pasta% 
	rd %pasta%
	echo.
	echo -------------------------------------------------
	echo  Arquivos e pastas excluídos com Sucesso!
	echo -------------------------------------------------
	pause > nul
	goto inicio) else (goto inicio)

:sair
echo.
set /p resp=Deseja realmente encerrar[S/N]:
if /i %resp% equ s (exit) else (goto:inicio)