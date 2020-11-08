<?xml version = "1.0"?>
<xsl:stylesheet
        xmlns:xsl ="http://www.w3.org/1999/XSL/Transform" version ="1.0">
  <xsl:output method = "html"/>
  <xsl:template match = "MusicArtists">
    <html>
      <body>
        <table border = "1" width ="1200">
          <TR>
            <th>Name</th>
            <th>MajorGenre</th>
            <th>Country</th>
            <th>IncomePerYear</th>
            <th>ArtistBand</th>
            <th>MusicActivity</th>
          </TR>
        <xsl:for-each select= "//MusicArtist">
          <tr>
            <td>
              <xsl:value-of select= "@Name"/>
            </td>
            <td>
              <xsl:value-of select= "@MajorGenre"/>
            </td>
            <td>
              <xsl:value-of select= "@Country"/>
            </td>
            <td>
              <xsl:value-of select= "@IncomePerYear"/>
            </td>
            <td>
              <xsl:value-of select= "@ArtistBand"/>
            </td>
            <td>
              <xsl:value-of select= "@MusicActivity"/>
            </td>
          </tr>   
        </xsl:for-each>
        </table>
      </body>
    </html>
  </xsl:template>
</xsl:stylesheet>