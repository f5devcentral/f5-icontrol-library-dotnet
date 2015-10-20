param($file)

$lines = Get-Content $file;
foreach ($line in $lines) {
  $line = $line.Replace(".cs", "");
  Write-Output "`t`tprivate $line m_$line;";
}

foreach ($line in $lines) {
  $line = $line.Replace(".cs", "");
  $str = "`t`tpublic $line $line { get { verifyInitialized(); if (null == m_$line) { initializeInterface(m_$line = new $line()); } return m_$line; } }";
  Write-Output $str;
}
