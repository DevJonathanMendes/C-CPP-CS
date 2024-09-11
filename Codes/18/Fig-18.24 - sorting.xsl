<?xml version="1.0"?>

<!-- Fig. 18.24: sorting.xsl -->
<!-- Transformação de informações de livros em XHTML. -->

<xsl:stylesheet version="1.0"
	xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

	<!-- Grava a declaração XML e as informações da DTD DOCTYPE. -->
	<xsl:output method="xml" omit-xml-declaration="no" doctype-system="http://www.w3.org/TR/xhtml1/DTD/xhtml1-strict.dtd" doctype-public="-//W3C//DTD XHTML 1.0 Strict//EN" />

	<!-- Faz a correspondência com a raiz do documento. -->
	<xsl:template match="/">
		<html xmlns="http://www.w3.org/1999/xhtml">
			<xsl:apply-templates />
		</html>
	</xsl:template>

	<!-- Faz correspondência com book -->
	<xsl:template match="book">
		<head>
			<title>
				<xsl:value-of select="@isbn"/>
 -				<xsl:value-of select="title"/>
			</title>
		</head>
		<body>
			<h1 style="color: blue">
				<xsl:value-of select="title"/>
			</h1>
			<h2 style="color: blue">
            by <xsl:value-of select="author/lastName"/>
			</h2>
			<table style="border-style: groove; background-color: wheat">
				<xsl:for-each select="chapters/frontmatter/*">
					<tr>
						<td style="text-align: right">
							<xsl:value-of select="name()" />
						</td>
						<td>
                        (							<xsl:value-of select="pages" />
 pages)
						</td>
					</tr>
				</xsl:for-each>
				<xsl:for-each select="chapters/chapter">
					<xsl:sort select="@number" data-type="number" order="ascending" />
					<tr>
						<td style="text-align: right">
                        Chapter <xsl:value-of select="@number" />
						</td>
						<td>
                        (							<xsl:value-of select="pages" />
 pages)
						</td>
					</tr>
				</xsl:for-each>
				<xsl:for-each select="chapters/appendix">
					<xsl:sort select="@number" data-type="text" order="ascending" />
					<tr>
						<td style="text-align: right">
                        Appendix <xsl:value-of select="@number" />
						</td>
						<td>
                        (							<xsl:value-of select="@pages" />
 pages)
						</td>
					</tr>
				</xsl:for-each>
			</table>
			<br />
			<p style="color: blue">Pages:
				<xsl:variable name="pagecount" select="sum(chapters/*/pages)" />
				<xsl:value-of select="$pagecount" />
				<br />
            Media Type: <xsl:value-of select="media/type" />
			</p>
		</body>
	</xsl:template>

</xsl:stylesheet>
