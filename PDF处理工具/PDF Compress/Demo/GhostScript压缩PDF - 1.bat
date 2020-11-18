@echo off

gswin64 -sDEVICE=pdfwrite -dNOPAUSE -dBATCH -dQUIET -dCompatibilityLevel=1.4 -dPDFSETTINGS=/ebook -sOutputFile=output1.pdf input.pdf

pause