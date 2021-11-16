import { Component, OnInit } from '@angular/core';
import { Aluno } from '../models/aluno';
import { AlunoServicoService } from '../servicos/aluno-servico.service';

@Component({
  selector: 'app-lista-aluno',
  templateUrl: './lista-aluno.component.html',
  styleUrls: ['./lista-aluno.component.css']
})
export class ListaAlunoComponent implements OnInit {

  alunos: Aluno[] = [];

  constructor(private alunoServico: AlunoServicoService) { }

  ngOnInit(): void {
  }

  recuperarTodosAlunos() {
    this.alunoServico
          .getAlunos()
          .subscribe(alunos => this.alunos = alunos,
            _ => console.error('erro ao recuperar dados da api'));
  }

}
