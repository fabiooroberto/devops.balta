## Configurações de GIT

Setar configuração global de nome de branch  principal para novos projetos

```git
git config --global init.defaultBranch main 
```

Definir nome e email para os commits
```git
git config --global user.name "Seu Nome"
git config --global user.email "seuemail@mail.com"
```

Iniciar git local
```git
git init
```

Criar README.md se não existir com um texto, ou adicionar texto ao que já existe
```git
echo '# Meu título inicial' >> README.md
```

Adicionar arquivos para serem trackeados
```git
git add README.md
```

Para adicionar todos os arquivos
```git
git add --all
ou
git add .
```

Commitar um arquivo com mensagem
```git
git commit -m 'Minha mensagem do commit'
```

Adicionar a pasta para um repos
```git
git remote add origin https://github.com/minhaconta/meurepos.git
```

Enviar as para uma ramificação
```git
git push --set-upstream origin main
OU
git push -u origin main
```

Enviar as alterações para o repos vinculado
```github
git push
```

Atualizar branch local
```git
git pull
```

Adicionar gitignore para projetos em dotnet
```csharp
dotnet new gitignore
```

Abrir a pasta no explorer
```
ii .
```

Mudar de branch
```
git checkout MinhaBranch
```

Mudar para uma nova branch
```
git checkout -b feature/branch
```
