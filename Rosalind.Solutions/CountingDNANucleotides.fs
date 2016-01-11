namespace Rosalind.Solutions

module CountingDNANucleotides =

  let dnaString = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"

  let countAdinene =
    dnaString
    |> Seq.countBy (fun s -> if s = 'A' then "A" else "")
    |> Seq.toList

  let countCytosine =
    dnaString
    |> Seq.countBy (fun s -> if s = 'C' then "C" else "")
    |> Seq.toList

  let countGuanine =
    dnaString
    |> Seq.countBy (fun s -> if s = 'G' then "G" else "")
    |> Seq.toList

  let countThymine =
      dnaString
      |> Seq.countBy (fun s -> if s = 'T' then "T" else "")
      |> Seq.toList

  let countMolecules =
    countAdinene @ countCytosine @ countGuanine @ countThymine
    |> List.sort
    |> Seq.skipWhile (fun (molecule, count) -> molecule = "" )
