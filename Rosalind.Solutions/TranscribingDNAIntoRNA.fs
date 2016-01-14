namespace Rosalind.Solutions

open System
open System.IO

module TranscribingDNAIntoRNA =
  //let dnaString = "GATGGAACTTGACTACGTAAATT"

  let data =
    "Rosalind.Solutions/input/rosalind_dna.txt"
    |> File.ReadAllLines

  let dnaString = List.ofSeq data |> List.head

  let thymineToUracil molecule =
    if molecule = 'T' then 'U'
    else molecule

  let transform =
    dnaString
    |> Seq.map thymineToUracil
    |> Seq.iter (fun c -> printf "%c" c)

  transform;;
