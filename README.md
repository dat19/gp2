# ゲームプログラミング2 2019年度生(木曜日3,4)
- [シラバス](https://1drv.ms/x/s!Anf4PowESFUjg_tpWDguYAyq68lTyQ?e=jyA0e5)
- [SOLID原則](https://docs.google.com/document/d/1TVdyioxBuSwz89Vh92ziADulEB47P5IMolytxopdBrM/)
- [paiza開発日誌. 初心者がC#の基本からアプリ・ゲーム開発まで学ぶための記事まとめ](https://paiza.hatenablog.com/entry/2020/06/09/%E5%88%9D%E5%BF%83%E8%80%85%E3%81%8CC%23%E3%81%AE%E5%9F%BA%E6%9C%AC%E3%81%8B%E3%82%89%E3%82%A2%E3%83%97%E3%83%AA%E3%83%BB%E3%82%B2%E3%83%BC%E3%83%A0%E9%96%8B%E7%99%BA%E3%81%BE%E3%81%A7%E5%AD%A6%E3%81%B6)
- [GitHubの開発フロー](https://sketchboard.me/LBSAHzZ8ynEE)

# 6回目
## 話題
- [Monaca Education. Webフロントエンド開発の学習サービス](https://edu.monaca.io/)
- [paiza開発日誌. 50以上の言語に対応！何でも開発可能な無料のクラウドIDE「Repl.it」を使ってみた！](https://paiza.hatenablog.com/entry/2020/06/17/50%E4%BB%A5%E4%B8%8A%E3%81%AE%E8%A8%80%E8%AA%9E%E3%81%AB%E5%AF%BE%E5%BF%9C%EF%BC%81%E4%BD%95%E3%81%A7%E3%82%82%E9%96%8B%E7%99%BA%E5%8F%AF%E8%83%BD%E3%81%AA%E7%84%A1%E6%96%99%E3%81%AE%E3%82%AF%E3%83%A9)

## 内容
- [インターフェース分離の原則](https://docs.google.com/document/d/1rr_F_RpGMpeO7t5jodhnVVXSY4CdHLbWZlrWGFfOJPI/)の復習
  - ShieldDamageableを実装してみる
  - シールドオブジェクトの作成を実演
  - 演習にもう一度取り組む
- [依存関係逆転の原則](https://docs.google.com/document/d/1-wRF_0zVapL7yUDfpsdwAjlJq0rpkEiNWnN-AHVyEkM/)
  - できたら、ドキュメントの共有URLを[こちら](https://docs.google.com/spreadsheets/d/1Ky6bU27vJy_jl4-Yu3UiaHj-ZuHUPcQHXOVgjsRn-Mc/)に張り付ける
  - リンクを知っている全員が閲覧できるようにしてください
- 研究内容の進捗の確認と進め方の相談
- 卒業制作や研究についての質疑応答と作業

## プレイヤー方にダメージを与える方法の検討
- ◎プレイヤーサイドのダメージを呼び出すスクリプト
  - 今回は敵などの属性が特にないのでこれがシンプルそう
- 〇プレイヤーサイドにダメージを与えるかを返すスクリプト
  - 敵や弾に様々な属性があるなら、ここに含めることが考えられる
- △タグを使う
  - 実装は簡単だが、敵と敵の弾の2つのタグ判定が必要なのでちょっと微妙

※相手がだれかをタグなどで片っ端からifで判別するのは避けたい！

・敵や、敵の弾にアタッチするスクリプトAttackerを定義して、そこにパワーとダメージ処理の呼び出しを実装
・Attackerから呼び出すIPlayerDamageableインターフェースを定義
・シールドを作る。ShieldDamageableクラスにIPlayerDamageableを実装し、Damage処理と、シールドの強度、爆発時のExplosionプレハブを受け取る



## UnityのUI(uGUI)
- 新しいシーンを作って、*Scenes*フォルダーに`UI`という名前で保存
- [UnityのUI基礎](https://docs.google.com/document/d/1oUDdWBGk2XUjAyt7RLHL2a1shBwrZp-ghrOb4wzGddk/)

## PhotoshopでUIを作る
kyubuns氏作の[Baum2](https://github.com/kyubuns/Baum2)を使って、PhotoshopでUnityのUIを作成する。

- [CG METHOD. psdデータからuGUIにコンバートする方法](https://www.cg-method.com/entry/psd-to-ugui/)

## Photoshopで作った画像をレイヤー分割
- [テラシュールブログ. Photoshopで作った画像をレイヤー単位で分割、配置/描画順をそのままにSprite Renderで配置してくれる 「2D PSD Importer」](http://tsubakit1.hateblo.jp/entry/2018/12/18/200751#PSD-Importer)
  - [2d-animation-v2-samples](https://github.com/Unity-Technologies/2d-animation-v2-samples)

## 参考
- [Adobe. モバイルアプリおよびゲームエンジン用アニメーションの書き出し](https://helpx.adobe.com/jp/animate/using/create-sprite-sheet.html)




# 5回目
## 話題
- [Unity. Learn Premium が誰でも無料でご利用できるようになりました](https://blogs.unity3d.com/jp/2020/06/23/learn-premium-is-now-available-to-everyone-at-no-cost-forever/?utm_campaign=unitynews_japan_newsletter_2020-6-JP-June-Newsletter&utm_content=2020-6-JP-Newsletter-game&utm_medium=email&utm_source=Eloqua)

## 内容
- [インターフェース分離の原則](https://docs.google.com/document/d/1rr_F_RpGMpeO7t5jodhnVVXSY4CdHLbWZlrWGFfOJPI/)
  - できたら、ドキュメントの共有URLを[こちら](https://docs.google.com/spreadsheets/d/1Ky6bU27vJy_jl4-Yu3UiaHj-ZuHUPcQHXOVgjsRn-Mc/)に張り付ける
  - リンクを知っている全員が閲覧できるようにしてください
- 研究内容の進捗の確認と進め方の相談
- 卒業制作や研究についての質疑応答と作業


# 4回目
- [質問Meet](https://meet.google.com/yav-uzhd-wjq)

## 前回のOCPの復習、解答
- [演習3解答例](https://docs.google.com/presentation/d/1rr90TQ2Qgw30NOlbIC1UPNuG2kJjj6LMKdTk5UNX5zI/)


## 内容
- [リスコフの置換原則](https://docs.google.com/document/d/10FN9wUup3e7mO9zipqWuxM0HZHDAEnRzhO6w1Ql8WCw/)
  - できたら、ドキュメントの共有URLを[こちら](https://docs.google.com/spreadsheets/d/1Ky6bU27vJy_jl4-Yu3UiaHj-ZuHUPcQHXOVgjsRn-Mc/)に張り付ける
  - リンクを知っている全員が閲覧できるようにしてください
- 研究内容の進捗の確認と進め方の相談
- 卒業制作や研究についての質疑応答と作業



# 3回目

## 日曜日までの課題
- [オープンクローズドの原則](https://docs.google.com/document/d/1mOXcLZq31II1_8PwoAzSp4VkFMrtYipeXrmumFaWF-s/)の演習
  - できたら、ドキュメントの共有URLを[こちら](https://docs.google.com/spreadsheets/d/1Ky6bU27vJy_jl4-Yu3UiaHj-ZuHUPcQHXOVgjsRn-Mc/)に張り付ける
  - リンクを知っている全員が閲覧できるようにしてください

## ニュース
- [Maps SDK for Unity](https://developers.google.com/maps/documentation/gaming/overview_musk)
  - [Google Maps Platformの料金](https://cloud.google.com/maps-platform/pricing)
- [GCCONF '20：次世代ゲームに求められる新技術はこれだ！monoAI technology株式会社](https://youtu.be/-OFaLsoPEIg)

## 予定
- 課題の解答
  - [長期サービスの作品と円滑に開発するための案](https://docs.google.com/document/d/17PEOWseIHh-R4R9Jobu4GFYVB1fFfeXkmU6_SWvxlX4/)
- テーマブログについて
  - 出揃ったのを確認。一先ず現状で進めていく
  - 調べたり、分かったことは、すぐにブログに書き足していく(忘れるので)
- SOLID原則
  - オープン・クローズドの原則
- 卒業制作を進める
  - プロジェクトの共同作業の手順を確認 > [GitHubの開発フロー](https://sketchboard.me/LBSAHzZ8ynEE)
  - 仮のグラフィックを受け入れる準備

# 2回目
## 課題
- 単一責任の原則の演習・・・6/14(日) 23:59まで

## 内容
- GitHub Educationプログラムを申請(Unityのクラウドビルドが使いたいので)
  - 利用目的が学生自身がプロジェクトを作成することなので、クラスではなく、各々に取得してもらう
    - https://education.github.com/pack
  - 参考： [学生開発者パックへの応募](https://help.github.com/ja/github/teaching-and-learning-with-github-education/applying-for-a-student-developer-pack)
  - 参考： [kirohi. GitHub Student Developer Packに申請する方法](https://kirohi.com/apply_github_education)
  - 学校名： College of Digital Arts Tokyo
  - Upload image をクリック
  - スマホなどで撮影した学生証をGmailなどでPCに送信して、Drop file here or click to upload に写真のファイルをドラッグ＆ドロップ
  - 理由： I want to learn GitHub.
- [単一責任の原則](https://docs.google.com/document/d/1NhWvY9EkbmUHmRoxp88VGcuWKzzTOa2kpFJiHeWJtiU/)
- 卒業制作の準備
  - Unityプロジェクトの作成
  - グループCは、Trelloでチームを作成して、卒業制作用のボードを作成する
  - GitHubに、Unityプロジェクトをパブリッシュ
  - 解像度、ビルド設定
  - 作業の洗い出し
  - ブログの作成

## 今日までの課題
- ブログ-研究テーマを考えて、最低限、タイトルを作る
  - 限定公開でよい
  - 関連記事を検索してURLを貼り付ける
- https://docs.google.com/document/d/1WHlNEKhg_iqpEReh0ym9lpMSjmhjrhWGxXcyJ9T6EpY/ の確認問題のURLを[こちら](https://docs.google.com/spreadsheets/d/1Ky6bU27vJy_jl4-Yu3UiaHj-ZuHUPcQHXOVgjsRn-Mc/) の*演習ドキュメントのURL列*に張り付け

# 1回目：ガイダンス / ブログの開設と確認 / 最初の投稿
- [就職活動の準備](https://docs.google.com/document/d/1ZluBZXCagWVwOSjoujLNT7iobYZoAjUH8eWHcZzFsg4/)
- [SOLID原則](https://docs.google.com/document/d/1TVdyioxBuSwz89Vh92ziADulEB47P5IMolytxopdBrM/)
- [質問会議室](https://meet.google.com/udg-ngkq-rbc)
- ブログの開設と確認
  - [Qiita](https://qiita.com/)
  - [はてなブログ](https://hatenablog.com/)
  - [note](https://note.com/)
  - [WiX](https://ja.wix.com/)
- GitHub Educationへの応募
  - [GitHubがこの4月からパワーアップ](https://github.blog/2020-04-14-github-is-now-free-for-teams/)
- 設計について
- 時間が余ったら、卒業制作の希望の聞き取り
  - [マミーさん. チーム「密会取り締まり委員会」の発表](https://youtu.be/-qWwYVWgczA?t=6093)
  - [tnkさん. 「斬新さ」から考えるゲーム開発](https://youtu.be/-qWwYVWgczA?t=3002)
  - [EIKIさん. ゴリラが人類を強制的にSTAY HOMEさせるゲーム](https://youtu.be/-qWwYVWgczA?t=6719)

## 来週までにやること
- ブログ-研究テーマを考えて、最低限、タイトルを作る
  - 限定公開でよい
  - 関連記事を検索して、URLを貼り付ける
  - Google MeetにブログのURLを貼ってない人は、 [こちら](https://docs.google.com/spreadsheets/d/1Ky6bU27vJy_jl4-Yu3UiaHj-ZuHUPcQHXOVgjsRn-Mc/) にURLを報告
- https://docs.google.com/document/d/1WHlNEKhg_iqpEReh0ym9lpMSjmhjrhWGxXcyJ9T6EpY/ の確認問題をやる
- 時間があれば、Google Educationプログラムを申請
  

## 参考
- Herokuのアカウント作成
  - GitHub Edicationが取得できたら、以下で学生パックが使える。ただし、クレジットカードが必須なので、申し込まなくてもよい
    - https://jp.heroku.com/github-students
  
