# OfficeTools
高效办公的小工具集合

- PDF压缩工具（基于GhostScript库）
- PDF转换为Word（基于Spire.Pdf库）

<details>
  <summary><b>GhostScript</b></summary>

[Ghostscript官网](https://www.ghostscript.com/index.html)
  
```
@echo off
gswin64 -sDEVICE=pdfwrite -dCompatibilityLevel=1.4 -dPDFSETTINGS=/ebook -dNOPAUSE -dBATCH -dQUIET -sOutputFile=output.pdf input.pdf
pause
```
  
不同的压缩模式：

> -dPDFSETTINGS=/ebook,压缩比稍小，输出文件稍大，质量稍高

> -dPDFSETTINGS=/screen,压缩比最大，输出文件最小，质量最低

> -dPDFSETTINGS=/prepress,输出文件信息同Acrobat Distiller "Prepress Optimized"设置

> -dPDFSETTINGS=/default,缺省的，即大多数情况使用的压缩方式

```
gs -sDEVICE=pdfwrite -dCompatibilityLevel=1.4 -dDownsampleColorImages=true -dColorImageResolution=130 -dNOPAUSE -dBATCH -sOutputFile=output.pdf input.pdf
```

> -dColorImageResolution=130可以设置图像DPI大小


ps2pdf命令：

ps2pdf input.pdf output.pdf
此命令输出文件的格式大致同/prepress

**[⬆ Back to top](#table-of-contents)**

</details>
