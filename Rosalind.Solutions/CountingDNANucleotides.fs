namespace Rosalind.Solutions

open System
open System.IO

module CountingDNANucleotides =

  //let dnaChain = "AGCTTTTCATTCTGACTGCAACGGGCAATATGTCTCTGTGTGGATTAAAAAAAGAGTGTCTGATAGCAGC"

  let data =
    "Rosalind.Solutions/input/rosalind_dna.txt"
    |> File.ReadAllLines

  let dnaChain = List.ofSeq data |> List.head

  let adinene =
    dnaChain
    |> Seq.countBy (fun s -> if s = 'A' then "A" else "")
    |> Seq.toList

  let cytosine =
    dnaChain
    |> Seq.countBy (fun s -> if s = 'C' then "C" else "")
    |> Seq.toList

  let guanine =
    dnaChain
    |> Seq.countBy (fun s -> if s = 'G' then "G" else "")
    |> Seq.toList

  let thymine =
      dnaChain
      |> Seq.countBy (fun s -> if s = 'T' then "T" else "")
      |> Seq.toList

  let countMolecules =
    adinene @ cytosine @ guanine @ thymine
    |> List.sort
    |> Seq.skipWhile (fun (molecule, count) -> molecule = "" )
    |> Seq.iter (fun (a, b) -> printf "%d " b)
