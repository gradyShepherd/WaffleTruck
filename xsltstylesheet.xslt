<?xml version="1.0"?>

<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">

<xsl:template match="/">
		<html>
			<body>
				<h2>News Feed</h2>
				
				<table border="0">
					<xsl: for-each select="stuff/news">
						<tr>
							<td><xsl:value-of select="image"/></td>
							<td><xsl:value-of select="title"/></td>
							<td><xsl:value-of select="description"/></td>
						</tr>
					</xsl:for-each>
				</table>
			</body>
		</html>
	</xsl:template>
</xsl:stylesheet>